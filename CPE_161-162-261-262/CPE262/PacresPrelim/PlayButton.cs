using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacresPrelim
{
    public class PlayButton
    {
        private List<Image> _imagesLogo;
        private int _currentImageIndex;
        public List<Image> ImagesLogo => _imagesLogo;
        public int CurrentImageIndex => _currentImageIndex;
        public void LoadPlayButton()
        {
            try
            {
                _imagesLogo = new List<Image>
                {
                    Image.FromFile("p0.gif"),
                    Image.FromFile("p1.gif"),
                    Image.FromFile("p2.gif"),
                    Image.FromFile("p3.gif"),
                    Image.FromFile("p4.gif"),
                    Image.FromFile("p5.gif"),
                    Image.FromFile("p6.gif"),
                    Image.FromFile("p7.gif"),
                    Image.FromFile("p8.gif"),
                    Image.FromFile("p9.gif"),
                    Image.FromFile("p10.gif"),
                    Image.FromFile("p11.gif"),
                    Image.FromFile("p12.gif"),
                    Image.FromFile("p13.gif"),
                    Image.FromFile("p14.gif"),
                    Image.FromFile("p15.gif"),
                    Image.FromFile("p16.gif"),
                    Image.FromFile("p17.gif"),
                    Image.FromFile("p18.gif"),
                    Image.FromFile("p19.gif"),
                    Image.FromFile("p20.gif"),
                    Image.FromFile("p21.gif"),
                    Image.FromFile("p22.gif"),
                    Image.FromFile("p23.gif"),
                    Image.FromFile("p24.gif"),
                    Image.FromFile("p25.gif"),
                    Image.FromFile("p26.gif"),
                    Image.FromFile("p27.gif"),
                    Image.FromFile("p28.gif"),
                    Image.FromFile("p29.gif"),
                    Image.FromFile("p30.gif"),
                    Image.FromFile("p31.gif"),
                    Image.FromFile("p32.gif"),
                    Image.FromFile("p33.gif"),
                    Image.FromFile("p34.gif"),
                    Image.FromFile("p35.gif"),
                    Image.FromFile("p36.gif"),
                    Image.FromFile("p37.gif"),
                    Image.FromFile("p38.gif"),
                    Image.FromFile("p39.gif"),
                    Image.FromFile("p40.gif"),
                    Image.FromFile("p41.gif"),
                    Image.FromFile("p42.gif"),
                    Image.FromFile("p43.gif"),
                    Image.FromFile("p44.gif"),
                    Image.FromFile("p45.gif"),
                    Image.FromFile("p46.gif"),
                    Image.FromFile("p47.gif"),
                    Image.FromFile("p48.gif"),
                    Image.FromFile("p49.gif"),
                    Image.FromFile("p50.gif"),
                    Image.FromFile("p51.gif"),
                    Image.FromFile("p52.gif"),
                    Image.FromFile("p53.gif"),
                    Image.FromFile("p54.gif"),
                    Image.FromFile("p55.gif"),
                    Image.FromFile("p56.gif"),
                    Image.FromFile("p57.gif"),
                    Image.FromFile("p58.gif"),
                    Image.FromFile("p59.gif"),
                    Image.FromFile("p60.gif"),
                    Image.FromFile("p61.gif"),
                    Image.FromFile("p62.gif"),
                    Image.FromFile("p63.gif"),
                    Image.FromFile("p64.gif"),
                    Image.FromFile("p65.gif"),
                    Image.FromFile("p66.gif"),
                    Image.FromFile("p67.gif"),
                    Image.FromFile("p68.gif"),
                    Image.FromFile("p69.gif"),
                    Image.FromFile("p70.gif"),
                    Image.FromFile("p71.gif"),
                    Image.FromFile("p72.gif"),
                    Image.FromFile("p73.gif"),
                    Image.FromFile("p74.gif"),
                    Image.FromFile("p75.gif"),
                    Image.FromFile("p76.gif"),
                    Image.FromFile("p77.gif"),
                    Image.FromFile("p78.gif"),
                    Image.FromFile("p79.gif"),
                    Image.FromFile("p80.gif"),
                    Image.FromFile("p81.gif"),
                    Image.FromFile("p82.gif"),
                    Image.FromFile("p83.gif"),
                    Image.FromFile("p84.gif"),
                    Image.FromFile("p85.gif"),
                    Image.FromFile("p86.gif"),
                    Image.FromFile("p87.gif"),
                    Image.FromFile("p88.gif"),
                    Image.FromFile("p89.gif"),
                    Image.FromFile("p90.gif"),
                    Image.FromFile("p91.gif"),
                    Image.FromFile("p92.gif"),
                    Image.FromFile("p93.gif"),
                    Image.FromFile("p94.gif"),
                    Image.FromFile("p95.gif"),
                    Image.FromFile("p96.gif"),
                    Image.FromFile("p97.gif"),
                    Image.FromFile("p98.gif"),
                    Image.FromFile("p99.gif"),
                    Image.FromFile("p100.gif"),
                    Image.FromFile("p101.gif"),
                    Image.FromFile("p102.gif"),
                    Image.FromFile("p103.gif"),
                    Image.FromFile("p104.gif"),
                    Image.FromFile("p105.gif"),
                    Image.FromFile("p106.gif"),
                    Image.FromFile("p107.gif"),
                    Image.FromFile("p108.gif"),
                    Image.FromFile("p109.gif"),
                    Image.FromFile("p110.gif"),
                    Image.FromFile("p111.gif"),
                    Image.FromFile("p112.gif"),
                    Image.FromFile("p113.gif"),
                    Image.FromFile("p114.gif"),
                    Image.FromFile("p115.gif"),
                    Image.FromFile("p116.gif"),
                    Image.FromFile("p117.gif"),
                    Image.FromFile("p118.gif"),
                    Image.FromFile("p119.gif"),
                    Image.FromFile("p120.gif"),
                    Image.FromFile("p121.gif"),
                    Image.FromFile("p122.gif"),
                    Image.FromFile("p123.gif"),
                    Image.FromFile("p124.gif"),
                    Image.FromFile("p125.gif"),
                    Image.FromFile("p126.gif"),
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading images: {ex.Message}");
            }
        }

        public Image GetNextImage()
        {
            _currentImageIndex++;
            if (_currentImageIndex >= _imagesLogo.Count)
            {
                _currentImageIndex = 0; // Loop back to the first image
            }

            return _imagesLogo[_currentImageIndex];
        }
    }
}