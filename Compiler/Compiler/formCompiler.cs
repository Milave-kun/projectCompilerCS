using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace Compiler
{
    public partial class formCompiler : Form
    {
        public formCompiler()
        {
            InitializeComponent();
        }

        List<string> lines = new();
        List<string> lexemes = new();
        List<string> tokens = new();
        List<string> dataTypes = new List<string>
        {
            "int","double","boolean","char","String"
        };
        List<string> fixedTokens = new List<string>
        {
            "<data_type>","<identifier>","<assignment_operator>","<value>","<delimiter>"
        };

        // Button Open File
        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    //Display file content on the text area
                    string fileContents = File.ReadAllText(filePath);
                    txtCodeTextArea.Text = fileContents;

                    //Read all lines from the file and store them in a List<string>
                    lines = ReadLinesFromFile(filePath);

                    //ReadLinesFromFile()
                    List<string> ReadLinesFromFile(string filePath)
                    {
                        // Read all lines from the file and add them to the List
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();
                                lines.Add(line);
                            }
                        }
                        return lines;
                    }

                    // Enable/Disable necessary buttons
                    btnLexicalAnalysis.Enabled = true;
                    btnClear.Enabled = true;
                    btnOpenFile.Enabled = false;
                }

                catch (Exception ex)
                {
                    // Handle file reading errors
                    MessageBox.Show("Error reading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                // Disable buttons or perform other actions here
                btnLexicalAnalysis.Enabled = false;
                btnClear.Enabled = false;
                btnOpenFile.Enabled = true; // Enable Open File button if the dialog is canceled
            }
        } // end OpenFile

        // Button Clear Text
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Display a warning message before clearing the text boxes
            DialogResult result = MessageBox.Show("Are you sure you want to clear the content?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // If the user clicks "Yes," clear the text boxes
                txtCodeTextArea.Clear();

                // Enable/Disable necessary buttons
                btnOpenFile.Enabled = true;
                btnClear.Enabled = false;
                btnLexicalAnalysis.Enabled = false;
                btnSyntaxAnalysis.Enabled = false;
                btnSemanticAnalysis.Enabled = false;
            }
            // If the user clicks "No," do nothing
        }

        // Button Lexical Analysis
        private void btnLexicalAnalysis_Click_1(object sender, EventArgs e)
        {
            bool isPass = true;

            // per line, split them to lexemes
            foreach (string line in lines)
            {
                string[] lexemeArr = Regex.Split(line, @"\s+"); //split by space
                lexemes = new List<string>(lexemeArr); // convert array to list

                // per lexeme, get its respective token
                foreach (string lexeme in lexemes)
                {
                    string token = getToken(lexeme);
                    tokens.Add(token);
                }

                // per token, check if they matches the token catalog
                foreach (string token in tokens)
                {
                    if (fixedTokens.Contains(token))
                    {
                        isPass = true;
                        continue;
                    }
                    else
                    {
                        isPass = false;
                        break; // stop reading next line if current line fails already
                    }
                }
                // clear tokens for the next line's tokens
                tokens.Clear();
            }

            // enable necessary button
            if (isPass)
            {
                btnSyntaxAnalysis.Enabled = true;
            }

            // display analysis result
            MessageBox.Show(isPass ? "Lexical analysis passed!" : "Lexical analysis failed!", "Analysis Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Disable the lexical analysis button after displaying result
            btnLexicalAnalysis.Enabled = false;

        }

        // getToken()
        private string getToken(string lexeme)
        {
            // use var for type inferencing
            var token = "";

            if (dataTypes.Contains(lexeme))
                token = "<data_type>";
            else if (lexeme.Equals("="))
                token = "<assignment_operator>";
            else if (lexeme.Equals(";"))
                token = "<delimiter>";
            else if (isValue(lexeme))
                token = "<value>";
            else if (isValidVar(lexeme))
                token = "<identifier>";
            return token;
        }

        // isValue()
        private bool isValue(string lexeme)
        {
            if (lexeme.StartsWith("\"") && lexeme.EndsWith("\""))
                return true;

            if (lexeme.StartsWith("\'") && lexeme.EndsWith("\'"))
            {
                if (lexeme.Length == 3 && char.IsLetter(lexeme[1]))
                    // dataType = "char";
                    return true;
                else
                    // dataType = "String";
                    return true;
            }

            if (Regex.IsMatch(lexeme, @"^\d+(\.\d+)?$")) // checks if value is numeric
                return true;

            return false;
        }

        // isValidVar()
        private bool isValidVar(string lexeme)
        {
            return char.IsLetter(lexeme[0]); // checks if var name starts with a letter
        }

        // Button Syntax Analysis
        private void btnSyntaxAnalysis_Click(object sender, EventArgs e)
        {
            // Perform syntax analysis here and display results in a message box

            // For example, you can check a condition and set the result
            string result = CheckSyntaxAnalysis(txtCodeTextArea.Text);

            // Display a message box based on the analysis result
            MessageBox.Show(result == "Accepted" ? "Syntax analysis passed!" : "Syntax analysis failed!", "Analysis Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Disable the syntax analysis button after displaying result
            btnSyntaxAnalysis.Enabled = false;
            btnSemanticAnalysis.Enabled = true;
        }

        // Sample syntax analysis function
        private string CheckSyntaxAnalysis(string code)
        {
            // Implement your syntax analysis logic here
            // This is a placeholder, you need to replace it with your actual logic

            // For example, check if the code contains a specific syntax pattern
            if (code.Contains("some syntax pattern"))
            {
                btnSemanticAnalysis.Enabled = true;
                return "Accepted";
            }
            else
            {
                return "Not Accepted";
            }
        }

        private void btnSemanticAnalysis_Click(object sender, EventArgs e)
        {
            bool isPass = true;

            foreach (string line in lines)
            {
                if (IsSemanticallyCorrect(line))
                {
                    isPass = true;
                    continue;
                }
                else
                {
                    isPass = false;
                    break;
                }
            }

            MessageBox.Show(isPass ? "Semantic analysis passed!" : "Semantic analysis failed!", "Analysis Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (isPass) { btnSemanticAnalysis.Enabled = false; }
            else { btnSemanticAnalysis.Enabled = true; }
        }

        public static bool IsSemanticallyCorrect(string expression)
        {
            string pattern = @"\s*(\w+)\s+(\w+)\s*=\s*([^;]+)\s*;";

            if (!Regex.IsMatch(expression, pattern))
            {
                return false;
            }

            string[] parts = expression.Split('=');
            string variableType = parts[0].Trim().Split(' ')[0];
            string value = parts[1].Trim().TrimEnd(';').Trim();

            try
            {
                switch (variableType)
                {
                    case "int":
                        int.Parse(value);
                        break;
                    case "double":
                        double.Parse(value);
                        break;
                    case "String":

                        break;
                    case "boolean":
                        bool.Parse(value);
                        break;
                    case "char":
                        char.Parse(value);
                        break;
                    default:
                        return false;
                }
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        // Button Close System
        private void btnCloseSystem_Click(object sender, EventArgs e)
        {
            // Display a warning message before closing the form
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // If the user clicks "Yes," close the form
                Close();
            }
            // If the user clicks "No," do nothing
        }

    }
}
