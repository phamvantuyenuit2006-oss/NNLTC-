using System;

namespace MyLib
{
    public class LibBaiTap
    {
        // Epsilon dung de so sanh so thuc double tranh sai so lam tron
        public const double EPS = 1e-9;

        /// <summary>
        /// Giai phuong trinh bac 2: a*x^2 + b*x + c = 0
        /// </summary>
        /// <param name="a">He so a</param>
        /// <param name="b">He so b</param>
        /// <param name="c">He so c</param>
        /// <param name="x1">Nghiem thu nhat (tham chieu ref)</param>
        /// <param name="x2">Nghiem thu hai (tham chieu ref)</param>
        /// <returns>
        /// -1: Vo so nghiem
        ///  0: Vo nghiem
        ///  1: Mot nghiem (hoac nghiem kep)
        ///  2: Hai nghiem phan biet (luon duoc sap xep tang dan x1 <= x2)
        /// </returns>
        public static int GiaiPTBac2(
            double a, double b, double c,
            ref double x1, ref double x2)
        {
            int sn;

            // Kiem tra a == 0 (su dung EPS cho so thuc)
            if (Math.Abs(a) < EPS)
            {
                if (Math.Abs(b) < EPS)
                {
                    if (Math.Abs(c) < EPS)
                    {
                        sn = -1; // Vo so nghiem (0x + 0 = 0)
                    }
                    else
                    {
                        sn = 0;  // Vo nghiem (0x + c = 0 voi c != 0)
                    }
                }
                else
                {
                    sn = 1;      // Phuong trinh bac nhat: bx + c = 0
                    x1 = -c / b;
                    x2 = x1;
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < -EPS)
                {
                    sn = 0;      // Delta < 0: Vo nghiem
                }
                else if (Math.Abs(delta) <= EPS)
                {
                    sn = 1;      // Delta == 0: Nghiem kep
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else
                {
                    sn = 2;      // Delta > 0: Hai nghiem phan biet
                    double sqrtDelta = Math.Sqrt(delta);
                    x1 = (-b - sqrtDelta) / (2 * a);
                    x2 = (-b + sqrtDelta) / (2 * a);

                    // Dam bao x1 <= x2 (nghiem luon duoc sap xep tang dan)
                    if (x1 > x2)
                    {
                        double tmp = x1;
                        x1 = x2;
                        x2 = tmp;
                    }
                }
            }

            return sn;
        }
    }

    /// <summary>
    /// Lop alias LibBai1 tuong thich theo tai lieu huong dan
    /// </summary>
    public class LibBai1 : LibBaiTap
    {
    }
}
