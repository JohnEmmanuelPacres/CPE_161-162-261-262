using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacresPrelim
{
    public class TitleDisplay
    {
        private List<Image> _imagesLogo;
        private int _currentImageIndex;
        public List<Image> ImagesLogo => _imagesLogo;
        public int CurrentImageIndex => _currentImageIndex;
        public void LoadTitleDisplay()
        {
            try
            {
                _imagesLogo = new List<Image>()
                {
                    Image.FromFile("t0.gif"),
                    Image.FromFile("t1.gif"),
                    Image.FromFile("t2.gif"),
                    Image.FromFile("t3.gif"),
                    Image.FromFile("t4.gif"),
                    Image.FromFile("t5.gif"),
                    Image.FromFile("t6.gif"),
                    Image.FromFile("t7.gif"),
                    Image.FromFile("t8.gif"),
                    Image.FromFile("t9.gif"),
                    Image.FromFile("t10.gif"),
                    Image.FromFile("t11.gif"),
                    Image.FromFile("t12.gif"),
                    Image.FromFile("t13.gif"),
                    Image.FromFile("t14.gif"),
                    Image.FromFile("t15.gif"),
                    Image.FromFile("t16.gif"),
                    Image.FromFile("t17.gif"),
                    Image.FromFile("t18.gif"),
                    Image.FromFile("t19.gif"),
                    Image.FromFile("t20.gif"),
                    Image.FromFile("t21.gif"),
                    Image.FromFile("t22.gif"),
                    Image.FromFile("t23.gif"),
                    Image.FromFile("t24.gif"),
                    Image.FromFile("t25.gif"),
                    Image.FromFile("t26.gif"),
                    Image.FromFile("t27.gif"),
                    Image.FromFile("t28.gif"),
                    Image.FromFile("t29.gif"),
                    Image.FromFile("t30.gif"),
                    Image.FromFile("t31.gif"),
                    Image.FromFile("t32.gif"),
                    Image.FromFile("t33.gif"),
                    Image.FromFile("t34.gif"),
                    Image.FromFile("t35.gif"),
                    Image.FromFile("t36.gif"),
                    Image.FromFile("t37.gif"),
                    Image.FromFile("t38.gif"),
                    Image.FromFile("t39.gif"),
                    Image.FromFile("t40.gif"),
                    Image.FromFile("t41.gif"),
                    Image.FromFile("t42.gif"),
                    Image.FromFile("t43.gif"),
                    Image.FromFile("t44.gif"),
                    Image.FromFile("t45.gif"),
                    Image.FromFile("t46.gif"),
                    Image.FromFile("t47.gif"),
                    Image.FromFile("t48.gif"),
                    Image.FromFile("t49.gif"),
                    Image.FromFile("t50.gif"),
                    Image.FromFile("t51.gif"),
                    Image.FromFile("t52.gif"),
                    Image.FromFile("t53.gif"),
                    Image.FromFile("t54.gif"),
                    Image.FromFile("t55.gif"),
                    Image.FromFile("t56.gif"),
                    Image.FromFile("t57.gif"),
                    Image.FromFile("t58.gif"),
                    Image.FromFile("t59.gif"),
                    Image.FromFile("t60.gif"),
                    Image.FromFile("t61.gif"),
                    Image.FromFile("t62.gif"),
                    Image.FromFile("t63.gif"),
                    Image.FromFile("t64.gif"),
                    Image.FromFile("t65.gif"),
                    Image.FromFile("t66.gif"),
                    Image.FromFile("t67.gif"),
                    Image.FromFile("t68.gif"),
                    Image.FromFile("t69.gif"),
                    Image.FromFile("t70.gif"),
                    Image.FromFile("t71.gif"),
                    Image.FromFile("t72.gif"),
                    Image.FromFile("t73.gif"),
                    Image.FromFile("t74.gif"),
                    Image.FromFile("t75.gif"),
                    Image.FromFile("t76.gif"),
                    Image.FromFile("t77.gif"),
                    Image.FromFile("t78.gif"),
                    Image.FromFile("t79.gif"),
                    Image.FromFile("t80.gif"),
                    Image.FromFile("t81.gif"),
                    Image.FromFile("t82.gif"),
                    Image.FromFile("t83.gif"),
                    Image.FromFile("t84.gif"),
                    Image.FromFile("t85.gif"),
                    Image.FromFile("t86.gif"),
                    Image.FromFile("t87.gif"),
                    Image.FromFile("t88.gif"),
                    Image.FromFile("t89.gif"),
                    Image.FromFile("t90.gif"),
                    Image.FromFile("t91.gif"),
                    Image.FromFile("t92.gif"),
                    Image.FromFile("t93.gif"),
                    Image.FromFile("t94.gif"),
                    Image.FromFile("t95.gif"),
                    Image.FromFile("t96.gif"),
                    Image.FromFile("t97.gif"),
                    Image.FromFile("t98.gif"),
                    Image.FromFile("t99.gif"),
                    Image.FromFile("t100.gif"),
                    Image.FromFile("t101.gif"),
                    Image.FromFile("t102.gif"),
                    Image.FromFile("t103.gif"),
                    Image.FromFile("t104.gif"),
                    Image.FromFile("t105.gif"),
                    Image.FromFile("t106.gif"),
                    Image.FromFile("t107.gif"),
                    Image.FromFile("t108.gif"),
                    Image.FromFile("t109.gif"),
                    Image.FromFile("t110.gif"),
                    Image.FromFile("t111.gif"),
                    Image.FromFile("t112.gif"),
                    Image.FromFile("t113.gif"),
                    Image.FromFile("t114.gif"),
                    Image.FromFile("t115.gif"),
                    Image.FromFile("t116.gif"),
                    Image.FromFile("t117.gif"),
                    Image.FromFile("t118.gif"),
                    Image.FromFile("t119.gif"),
                    Image.FromFile("t120.gif"),
                    Image.FromFile("t121.gif"),
                    Image.FromFile("t122.gif"),
                    Image.FromFile("t123.gif"),
                    Image.FromFile("t124.gif"),
                    Image.FromFile("t125.gif"),
                    Image.FromFile("t126.gif"),
                    Image.FromFile("t127.gif"),
                    Image.FromFile("t128.gif"),
                    Image.FromFile("t129.gif"),
                    Image.FromFile("t130.gif"),
                    Image.FromFile("t131.gif"),
                    Image.FromFile("t132.gif"),
                    Image.FromFile("t133.gif"),
                    Image.FromFile("t134.gif"),
                    Image.FromFile("t135.gif"),
                    Image.FromFile("t136.gif"),
                    Image.FromFile("t137.gif"),
                    Image.FromFile("t138.gif"),
                    Image.FromFile("t139.gif"),
                    Image.FromFile("t140.gif"),
                    Image.FromFile("t141.gif"),
                    Image.FromFile("t142.gif"),
                    Image.FromFile("t143.gif"),
                    Image.FromFile("t144.gif"),
                    Image.FromFile("t145.gif"),
                    Image.FromFile("t147.gif"),
                    Image.FromFile("t148.gif"),
                    Image.FromFile("t149.gif"),
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