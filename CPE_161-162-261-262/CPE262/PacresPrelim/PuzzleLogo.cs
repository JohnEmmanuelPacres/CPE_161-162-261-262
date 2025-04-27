using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacresPrelim
{
    public class PuzzleLogo
    {
        private List<Image> _imagesLogo;
        private int _currentImageIndex;
        public List<Image> ImagesLogo => _imagesLogo;
        public int CurrentImageIndex => _currentImageIndex;
        public void LoadLogoImages()
        {
            try
            {
                _imagesLogo = new List<Image>
                {
                    Image.FromFile("frame_000_delay-0.03s.gif"),
                    Image.FromFile("frame_001_delay-0.1s.gif"),
                    Image.FromFile("frame_002_delay-0.17s.gif"),
                    Image.FromFile("frame_003_delay-0.17s.gif"),
                    Image.FromFile("frame_004_delay-0.03s.gif"),
                    Image.FromFile("frame_005_delay-0.03s.gif"),
                    Image.FromFile("frame_006_delay-0.07s.gif"),
                    Image.FromFile("frame_007_delay-0.1s.gif"),
                    Image.FromFile("frame_008_delay-0.1s.gif"),
                    Image.FromFile("frame_009_delay-0.03s.gif"),
                    Image.FromFile("frame_010_delay-0.07s.gif"),
                    Image.FromFile("frame_011_delay-0.03s.gif"),
                    Image.FromFile("frame_012_delay-0.04s.gif"),
                    Image.FromFile("frame_013_delay-0.03s.gif"),
                    Image.FromFile("frame_014_delay-0.03s.gif"),
                    Image.FromFile("frame_015_delay-0.07s.gif"),
                    Image.FromFile("frame_016_delay-0.07s.gif"),
                    Image.FromFile("frame_017_delay-0.03s.gif"),
                    Image.FromFile("frame_018_delay-0.03s.gif"),
                    Image.FromFile("frame_019_delay-0.07s.gif"),
                    Image.FromFile("frame_020_delay-0.03s.gif"),
                    Image.FromFile("frame_021_delay-0.07s.gif"),
                    Image.FromFile("frame_022_delay-0.07s.gif"),
                    Image.FromFile("frame_023_delay-0.03s.gif"),
                    Image.FromFile("frame_024_delay-0.03s.gif"),
                    Image.FromFile("frame_025_delay-0.07s.gif"),
                    Image.FromFile("frame_026_delay-0.2s.gif"),
                    Image.FromFile("frame_027_delay-0.03s.gif"),
                    Image.FromFile("frame_028_delay-0.07s.gif"),
                    Image.FromFile("frame_029_delay-0.03s.gif"),
                    Image.FromFile("frame_030_delay-0.07s.gif"),
                    Image.FromFile("frame_031_delay-0.03s.gif"),
                    Image.FromFile("frame_032_delay-0.07s.gif"),
                    Image.FromFile("frame_033_delay-0.03s.gif"),
                    Image.FromFile("frame_034_delay-0.04s.gif"),
                    Image.FromFile("frame_035_delay-0.03s.gif"),
                    Image.FromFile("frame_036_delay-0.03s.gif"),
                    Image.FromFile("frame_037_delay-0.07s.gif"),
                    Image.FromFile("frame_038_delay-0.03s.gif"),
                    Image.FromFile("frame_039_delay-0.07s.gif"),
                    Image.FromFile("frame_040_delay-0.07s.gif"),
                    Image.FromFile("frame_041_delay-0.03s.gif"),
                    Image.FromFile("frame_042_delay-0.03s.gif"),
                    Image.FromFile("frame_043_delay-0.07s.gif"),
                    Image.FromFile("frame_044_delay-0.03s.gif"),
                    Image.FromFile("frame_045_delay-0.07s.gif"),
                    Image.FromFile("frame_046_delay-0.03s.gif"),
                    Image.FromFile("frame_047_delay-0.07s.gif"),
                    Image.FromFile("frame_048_delay-0.03s.gif"),
                    Image.FromFile("frame_049_delay-0.07s.gif"),
                    Image.FromFile("frame_050_delay-0.03s.gif"),
                    Image.FromFile("frame_051_delay-0.1s.gif"),
                    Image.FromFile("frame_052_delay-0.14s.gif"),
                    Image.FromFile("frame_053_delay-0.03s.gif"),
                    Image.FromFile("frame_054_delay-0.03s.gif"),
                    Image.FromFile("frame_055_delay-0.1s.gif"),
                    Image.FromFile("frame_056_delay-0.07s.gif"),
                    Image.FromFile("frame_057_delay-0.07s.gif"),
                    Image.FromFile("frame_058_delay-0.03s.gif"),
                    Image.FromFile("frame_059_delay-0.03s.gif"),
                    Image.FromFile("frame_060_delay-0.07s.gif"),
                    Image.FromFile("frame_061_delay-0.03s.gif"),
                    Image.FromFile("frame_062_delay-0.04s.gif"),
                    Image.FromFile("frame_063_delay-0.03s.gif"),
                    Image.FromFile("frame_064_delay-0.03s.gif"),
                    Image.FromFile("frame_065_delay-0.07s.gif"),
                    Image.FromFile("frame_066_delay-0.03s.gif"),
                    Image.FromFile("frame_067_delay-0.07s.gif"),
                    Image.FromFile("frame_068_delay-0.03s.gif"),
                    Image.FromFile("frame_069_delay-0.04s.gif"),
                    Image.FromFile("frame_070_delay-0.03s.gif"),
                    Image.FromFile("frame_071_delay-0.03s.gif"),
                    Image.FromFile("frame_072_delay-0.14s.gif"),
                    Image.FromFile("frame_073_delay-0.03s.gif"),
                    Image.FromFile("frame_074_delay-0.03s.gif"),
                    Image.FromFile("frame_075_delay-0.07s.gif"),
                    Image.FromFile("frame_076_delay-0.1s.gif"),
                    Image.FromFile("frame_077_delay-0.07s.gif"),
                    Image.FromFile("frame_078_delay-0.03s.gif"),
                    Image.FromFile("frame_079_delay-0.03s.gif"),
                    Image.FromFile("frame_080_delay-0.07s.gif"),
                    Image.FromFile("frame_081_delay-0.03s.gif"),
                    Image.FromFile("frame_082_delay-0.17s.gif"),
                    Image.FromFile("frame_083_delay-0.03s.gif"),
                    Image.FromFile("frame_084_delay-0.04s.gif"),
                    Image.FromFile("frame_085_delay-0.03s.gif"),
                    Image.FromFile("frame_086_delay-0.03s.gif"),
                    Image.FromFile("frame_087_delay-0.07s.gif"),
                    Image.FromFile("frame_088_delay-0.07s.gif"),
                    Image.FromFile("frame_089_delay-0.03s.gif"),
                    Image.FromFile("frame_090_delay-0.07s.gif"),
                    Image.FromFile("frame_091_delay-0.03s.gif"),
                    Image.FromFile("frame_092_delay-0.03s.gif"),
                    Image.FromFile("frame_093_delay-0.04s.gif"),
                    Image.FromFile("frame_094_delay-0.03s.gif"),
                    Image.FromFile("frame_095_delay-0.03s.gif"),
                    Image.FromFile("frame_096_delay-0.07s.gif"),
                    Image.FromFile("frame_097_delay-0.03s.gif"),
                    Image.FromFile("frame_098_delay-0.04s.gif"),
                    Image.FromFile("frame_099_delay-0.03s.gif"),
                    Image.FromFile("frame_100_delay-0.03s.gif"),
                    Image.FromFile("frame_101_delay-0.48s.gif")
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