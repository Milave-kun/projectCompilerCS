using System;
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

        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Enable Buttons or perform other action here

                // Read the contents of the file
                try
                {
                    string fileContents = File.ReadAllText(filePath);
                    txtCodeTextArea.Text = fileContents;

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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Display a warning message before clearing the text boxes
            DialogResult result = MessageBox.Show("Are you sure you want to clear the content?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // If the user clicks "Yes," clear the text boxes
                txtResult.Clear();
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

        private void btnLexicalAnalysis_Click_1(object sender, EventArgs e)
        {
            // Perform lexical analysis here and display results in the txtResult Text Area

            // For example, you can check a condition and set the result
            string result = CheckLexicalAnalysis(txtCodeTextArea.Text);

            // Display the result in the txtResult TextArea
            txtResult.Text = result;

            // Display a message box based on the analysis result
            MessageBox.Show(result == "Accepted" ? "Lexical analysis passed!" : "Lexical analysis failed!", "Analysis Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Disable the lexical analysis button after displaying result
            btnLexicalAnalysis.Enabled = false;

            // Sample lexical analysis function
        }

        private string CheckLexicalAnalysis(string code)
        {
            // Implement your lexical analysis logic here
            // This is a placeholder, you need to replace it with your actual logic

            // For example, check a condition and return "Accepted" or "Not Accepted"
            if (code.Contains("some condition"))
            {
                btnSyntaxAnalysis.Enabled = true;
                return "Accepted";
            }
            else
            {
                return "Not Accepted";
            }
        }
        private void btnSyntaxAnalysis_Click(object sender, EventArgs e)
        {
            // Perform syntax analysis here and display results in the txtResult TextArea

            // For example, you can check a condition and set the result
            string result = CheckSyntaxAnalysis(txtCodeTextArea.Text);

            // Display the result in the txtResult TextArea
            txtResult.Text = result;

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

        private void btnSemanticAnalysis_Click(object sender, EventArgs e)
        {
            // Perform semantic analysis here and display results in the txtResult TextArea

            // For example, you can check a condition and set the result
            string result = CheckSemanticAnalysis(txtCodeTextArea.Text);

            // Display the result in the txtResult TextArea
            txtResult.Text = result;

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
