using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class UCCarousel : UserControl
    {
        public List<Image> images = new List<Image>();
        int currentIndex = 0;
        public UCCarousel(List<Image> Images)
        {
            InitializeComponent();
            this.images = Images;
            if(Images.Count == 0)
            {
               this.BackgroundImage = Properties.Resources.noimg;
            }
            else
            {
                this.BackgroundImage = images[0];
                currentIndex = 0;
            }
        }
        public UCCarousel()
        {
            InitializeComponent();
        }

        private void btnLeftArrow_Click(object sender, EventArgs e)
        {
            if (images.Count > 1)
            {
                currentIndex = (currentIndex - 1 + images.Count) % images.Count;
                this.BackgroundImage = images[currentIndex];
            }
        }

        private void btnRightArrow_Click(object sender, EventArgs e)
        {
            if (images.Count > 1)
            {
                currentIndex = (currentIndex + 1) % images.Count;
                this.BackgroundImage = images[currentIndex];
            }
        }
        public void Delete()
        {
            if (images.Count > 0 && currentIndex < images.Count)
            {
                images.RemoveAt(currentIndex);

                if (images.Count > 0)
                {
                    // Update currentIndex to handle the case where the last image was deleted
                    if (currentIndex >= images.Count)
                    {
                        currentIndex = images.Count - 1;
                    }
                    this.BackgroundImage = images[currentIndex];
                }
                else
                {
                    // If there are no more images, set background to default image
                    this.BackgroundImage = Properties.Resources.noimg;
                }
            }
        }
        public void Add()
        {
            Image image = ImageHandler.ChoosePicture();

            if (image != null)
            {
                images.Add(image);
                // If this is the first image added, set it as the background image
                if (images.Count == 1)
                {
                    this.BackgroundImage = image;
                }
            }
        }
    }
}
