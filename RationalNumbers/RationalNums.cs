using System;
using System.Collections.Generic;
using System.Text;

namespace RationalNumbers
{
    class RationalNums
    {
        private int chis;
        private int znam;

        public int Chis
        {
            get
            {
                return chis;
            }
            set
            {
                chis = value;
            }
        }

        public int Znam
        {
            get
            {
                return znam;
            }
            set
            {
                znam = value;
            }
        }
        public RationalNums(int chislitel = 1, int znamenatel = 1)
        {
            if (znamenatel == 0)
            {
                throw new ArgumentException("Знаменатель не может быть нулём, ёлки-палки. Хочешь, чтобы вселенная схлопнулась?");
            }
            chis = chislitel;
            znam = znamenatel;
        }

        public static RationalNums operator +(RationalNums a, RationalNums b)
        {
            RationalNums res = new RationalNums();
            if (a.Znam == b.Znam)
            {
                res.Chis = a.Chis + b.Chis;
                res.Znam = a.Znam;

                int max = res.Znam;
                if (max < -res.Chis)
                {
                    max = -res.Chis;
                }
                if (max < res.Chis)
                {
                    max = res.Chis;
                }
                for (int i = max / 2; i > 1; i--)
                {
                    if (res.Chis % i == 0 && res.Znam % i == 0)
                    {
                        res.Chis /= i;
                        res.Znam /= i;
                        return res;
                    }
                }
            }
            else
            {
                res.Chis = a.Chis * b.Znam + a.Znam * b.Chis;
                res.Znam = a.Znam * b.Znam;

                int max = res.Znam;
                if (max < -res.Chis)
                {
                    max = -res.Chis;
                }
                if (max < res.Chis)
                {
                    max = res.Chis;
                }
                for (int i = max / 2; i > 1; i--)
                {
                    if (res.Chis % i == 0 && res.Znam % i == 0)
                    {
                        res.Chis /= i;
                        res.Znam /= i;
                        return res;
                    }
                }
            }
            return res;
        }

        public static RationalNums operator -(RationalNums a, RationalNums b)
        {
            RationalNums res = new RationalNums();
            if (a.Znam == b.Znam)
            {
                res.Chis = a.Chis - b.Chis;
                res.Znam = a.Znam;
                
                int max = res.Znam;
                if (max < -res.Chis)
                {
                    max = -res.Chis;
                }
                if(max < res.Chis)
                {
                    max = res.Chis;
                }
                for (int i = max/2; i > 1; i--)
                {
                    if (res.Chis % i == 0 && res.Znam % i == 0)
                    {
                        res.Chis /= i;
                        res.Znam /= i;
                        return res;
                    }
                }
            }
            else
            {
                res.Chis = a.Chis * b.Znam - a.Znam * b.Chis;
                res.Znam = a.Znam * b.Znam;

                int max = res.Znam;
                if (max < -res.Chis)
                {
                    max = -res.Chis;
                }
                if (max < res.Chis)
                {
                    max = res.Chis;
                }
                for (int i = max / 2; i > 1; i--)
                {
                    if (res.Chis % i == 0 && res.Znam % i == 0)
                    {
                        res.Chis /= i;
                        res.Znam /= i;
                        return res;
                    }
                }
            }
            return res;
        }

        public static RationalNums operator *(RationalNums a, RationalNums b)
        {
            RationalNums res = new RationalNums();
            res.Chis = a.Chis * b.Chis;
            res.Znam = a.Znam * b.Znam;

            int max = res.Znam;
            if (max < -res.Chis)
            {
                max = -res.Chis;
            }
            if (max < res.Chis)
            {
                max = res.Chis;
            }
            for (int i = max / 2; i > 1; i--)
            {
                if (res.Chis % i == 0 && res.Znam % i == 0)
                {
                    res.Chis /= i;
                    res.Znam /= i;
                    return res;
                }
            }
            return res;
        }

        public static RationalNums operator /(RationalNums a, RationalNums b)
        {
            RationalNums res = new RationalNums();
            res.Chis = a.Chis * b.Znam;
            res.Znam = a.Znam * b.Chis;

            int max = res.Znam;
            if (max < -res.Chis)
            {
                max = -res.Chis;
            }
            if (max < res.Chis)
            {
                max = res.Chis;
            }
            for (int i = max / 2; i > 1; i--)
            {
                if (res.Chis % i == 0 && res.Znam % i == 0)
                {
                    res.Chis /= i;
                    res.Znam /= i;
                    return res;
                }
            }
            return res;
        }

        public static bool operator >(RationalNums a, RationalNums b)
        {
            if (a.Znam == b.Znam)
            {
                if(a.Chis > b.Chis)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(a.Chis == b.Chis)
            {
                if (a.Znam < b.Znam)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                RationalNums ta = new RationalNums();
                RationalNums tb = new RationalNums();
                ta.Chis = a.Chis * b.Znam;
                ta.Znam = a.Znam * b.Znam;
                tb.Chis = b.Chis * a.Znam;
                tb.Znam = a.Znam * b.Znam;
                if (ta > tb)
                {
                    return true;
                }
                else return false;
                
            }
        }

        public static bool operator <(RationalNums a, RationalNums b)
        {
            if (a.Znam == b.Znam)
            {
                if (a.Chis < b.Chis)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (a.Chis == b.Chis)
            {
                if (a.Znam > b.Znam)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                RationalNums ta = new RationalNums();
                RationalNums tb = new RationalNums();
                ta.Chis = a.Chis * b.Znam;
                ta.Znam = a.Znam * b.Znam;
                tb.Chis = b.Chis * a.Znam;
                tb.Znam = a.Znam * b.Znam;
                if (ta < tb)
                {
                    return true;
                }
                else return false;

            }
        }


        public void Print()
        {
            if (chis < 0)
            {
                Console.Write($"-({-chis}/{znam})");
            }
            else Console.Write($"{chis}/{znam}");
        }
    }
}