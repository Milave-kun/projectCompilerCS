﻿using System;
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

       // List<string> lines = new();
        List<string> lexemes = new();
        List<string> tokens = new();
        List<string> dataTypes = new List<string>
        {
            "int","float","boolean","char","String"
        };
        List<string> fixedTokens = new List<string>
        {
            "<data_type>","<identifier>","<assignment_operator>","<value>","<delimiter>"
        };
        string lines = "";

// Button Open File
        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    //string fileContents = File.ReadAllText(filePath);
                    //txtCodeTextArea.Text = fileContents;

                    lines = File.ReadAllText(filePath);
                    Console.WriteLine(lines);
                    txtCodeTextArea.Text = lines;

                    // Read all lines from the file and store them in a List<string>
                    //lines = ReadLinesFromFile(filePath);


                    //List<string> ReadLinesFromFile(string filePath)
                    //{
                    //    List<string> liness = new List<string>();

                    //    // Read all lines from the file and add them to the List
                    //    using (StreamReader reader = new StreamReader(filePath))
                    //    {
                    //        while (!reader.EndOfStream)
                    //        {
                    //            string line = reader.ReadLine();
                    //            liness.Add(line);
                    //        }
                    //    }
                    //    return liness;
                    //}

                    // Enable lexical analysis button
                    btnLexicalAnalysis.Enabled = true;
                    // Enable Clear button
                    btnClear.Enabled = true;
                    // Disable Open File button
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
        } // openFile

// Button Clear Text
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Display a warning message before clearing the text boxes
            DialogResult result = MessageBox.Show("Are you sure you want to clear the content?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // If the user clicks "Yes," clear the text boxes
                txtCodeTextArea.Clear();

                // Enable Open File button
                btnOpenFile.Enabled = true;
                // Disable Clear button
                btnClear.Enabled = false;
                // Disable other analysis buttons
                btnLexicalAnalysis.Enabled = false;
                btnSyntaxAnalysis.Enabled = false;
                btnSemanticAnalysis.Enabled = false;
            }
            // If the user clicks "No," do nothing
        }

// Button Lexical Analysis
        private void btnLexicalAnalysis_Click_1(object sender, EventArgs e)
        {
            
            string result = "";
            // Perform lexical analysis here and display results in a message box

            // take each line to split them to lexemes
            //foreach (string line in lines)
            //{
              
                    bool isPass = true;

            // split each word by space
            // store to array
            // convert array to list
            // Console.WriteLine(lines);

            string lines = "String,greeting";
            int liness = lines.Count();
            Console.WriteLine(liness);
            string[] lexemeArray = Regex.Split(lines, @"\s+");
            Console.WriteLine(lexemeArray);
                   lexemes = new List<string>(lexemeArray);
            Console.WriteLine(lexemes);
            foreach (string lexeme in lexemes)
                    {
                        string token = getToken(lexeme);
                        tokens.Add(token);

                    }
                    

                    foreach (string token in tokens)
                    {
                        if (!fixedTokens.Contains(token))
                        {
                            isPass = false;
                            break;
                        }

                    
                    }

                    ////clear Lists for the next line
                    //lexemes.Clear();
                    //tokens.Clear();

                //if (!isPass)
                //{
                //    // No need to continue checking lines if isPass is false
                //    break;
                //}
            //}

           

            // update result
            if (result.Equals("Pass"))
            {
               
                btnSyntaxAnalysis.Enabled = true;
            }
               

            // Display a message box based on the analysis result
            MessageBox.Show(result == "Pass" ? "Lexical analysis passed!" : "Lexical analysis failed!", "Analysis Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Disable the lexical analysis button after displaying result
            btnLexicalAnalysis.Enabled = false;

         
        }

       

        // my sample function
        // findToken
        private string getToken (string lexeme)
        {
            // use var for type inferencing
            var token = ""; 

            // check if lexeme is equal to any of the data types
            if (dataTypes.Contains(lexeme))
                token = "<data_type>";
            
            else if (lexeme.Equals("="))
                token = "<assignment_operator>";
            
            else if (lexeme.Equals(";"))
                token = "<delimiter>";
            
            else if (isValidVar(lexeme))
                token = "<identifier>";
            
            else if (isValue(lexeme))
                token = "<value>";
            

            return token;
        }

        private bool isValidVar (string lexeme)
        {
            //if (dataTypes.Contains(lexeme))
            //    return false;

            //if (!char.IsLetter(lexeme[0]))
              return false;
            
            //return char.IsLetter(lexeme[0]);
            
        }

        private bool isValue (string lexeme)
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
            

            if (int.TryParse(lexeme, out _))
                return true;

            
            return false;
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

// Button Semantical Analysis
        private void btnSemanticAnalysis_Click(object sender, EventArgs e)
        {
            // Perform semantic analysis here and display results in a message box

            // For example, you can check a condition and set the result
            string result = CheckSemanticAnalysis(txtCodeTextArea.Text);

            // Display a message box based on the analysis result
            MessageBox.Show(result == "Accepted" ? "Semantic analysis passed!" : "Semantic analysis failed!", "Analysis Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Disable the semantic analysis button after displaying result
            btnSemanticAnalysis.Enabled = false;
        }

        // Sample semantic analysis function
        private string CheckSemanticAnalysis(string code)
        {
            // Implement your semantic analysis logic here
            // This is a placeholder, you need to replace it with your actual logic

            // For example, check if the code adheres to specific semantic rules
            if (code.Contains("some semantic rule"))
            {
                return "Accepted";
            }
            else
            {
                return "Not Accepted";
            }
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
