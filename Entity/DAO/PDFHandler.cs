using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace WinFormProject.OOPCODE
{
    public static class PDFHandler
    {
        public static void DisplayPDFInWebBrowser(byte[] pdfData,ref WebBrowser webBrowser)
        {
            try
            {
                // Create a temporary file path
                string tempFilePath = Path.Combine(Path.GetTempPath(), "temp.pdf");

                // Write the PDF byte array to a temporary file
                File.WriteAllBytes(tempFilePath, pdfData);

                // Check if the file was written successfully
                if (File.Exists(tempFilePath))
                {
                    // Navigate the WebBrowser control to the temporary file
                    webBrowser.Navigate(tempFilePath);
                }
                else
                {
                    MessageBox.Show("Error: Failed to write PDF data to temporary file.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static byte[] OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            byte[] pdfBytes = new byte[0];
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read PDF file into byte array
                pdfBytes = File.ReadAllBytes(openFileDialog.FileName);

            }
            return pdfBytes;
        }
    }
 }

