using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf;
using System.IO;
using Syncfusion.Pdf.Parsing;

namespace Entity
{
    public static class ImageHandler
    {

        public static byte[] ImageToByteArray(Image img)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                // Save the image in JPEG format
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public static Image ByteArrayToImage(byte[] imageData)
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        public static List<byte[]> ConvertListImgToListByte(List<Image> listimg)
        {
            List<byte[]> resultList = new List<byte[]>();
            foreach (Image img in listimg)
            {
                byte[] byteArray = ImageToByteArray(img);
                resultList.Add(byteArray);
            }
            return resultList;
        }

        public static List<Image> ConvertListByteToListImage(List<byte[]> listbyte)
        {
            List<Image> resultList = new List<Image>();
            foreach (byte[] byteArray in listbyte)
            {
                Image image = ByteArrayToImage(byteArray);
                resultList.Add(image);
            }
            return resultList;
        }
        public static void ChoosePicture(ref Guna.UI2.WinForms.Guna2PictureBox ptb)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ptb.ImageLocation = openFileDialog.FileName;
                }
            }
        }
        public static Image ChoosePicture()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg)|*.jpg;*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image and set it as the background image of the panel
                    return Image.FromFile(openFileDialog.FileName);
                }
            }
            return null;
        }

        public static void DisplayPdfPreview(byte[] pdfBytes, PictureBox ptbCv)
        {
            // Convert PDF to image
            Image previewImage = ConvertPdfToImage(pdfBytes);

            // Display the image in PictureBox
            ptbCv.Image = previewImage;
        }

        private static Image ConvertPdfToImage(byte[] pdfBytes)
        {
            using (MemoryStream memoryStream = new MemoryStream(pdfBytes))
            {
                // Load PDF document
                using (PdfLoadedDocument loadedDocument = new PdfLoadedDocument(memoryStream))
                {
                    // Check if the document has pages
                    if (loadedDocument.Pages.Count > 0)
                    {
                        // Render first page as image
                        using (Bitmap bitmap = loadedDocument.ExportAsImage(0))
                        {
                            // Convert bitmap to Image object
                            Image image = bitmap.Clone() as Image;
                            return image;
                        }
                    }
                }
            }
            return null;
        }
    }
}
