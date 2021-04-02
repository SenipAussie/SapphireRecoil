﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sens_Sapphire_Recoil
{
    class RecoilTables
    {
        public static readonly int[,] AssaultRifle = { { -69, 100 }, { 10, 92 }, { -110, 83 }, { -85, 75 }, { 0, 67 }, { 33, 57 }, { 58, 48 }, { 76, 39 }, { 84, 29 }, { 85, 19 }, { 76, 20 }, { 60, 37 }, { 34, 50 }, { 2, 59 }, { -30, 65 }, { -55, 67 }, { -74, 64 }, { -86, 59 }, { -92, 49 }, { -91, 34 }, { -84, 17 }, { -70, 10 }, { -49, 28 }, { -22, 42 }, { 24, 51 }, { 72, 56 }, { 97, 57 }, { 98, 51 }, { 77, 43 } };
        public static readonly double[] AssaultRifleControlTime = { 121.96149709966872, 92.6333814724611, 138.60598637206294, 113.37874368443146, 66.25151186427745, 66.29530438019354, 75.9327831420658, 85.05526144256157, 89.20256669256554, 86.68010184667988, 78.82145888317788, 70.0451048111144, 60.85979604582978, 59.51642457624619, 71.66762996283607, 86.74060009403034, 98.3363599080854, 104.34161954944257, 104.09299204005345, 97.58780746901739, 85.48062700875559, 70.4889202349561, 56.56417811530545, 47.386907899993936, 56.63787408680247, 91.5937793023631, 112.38667610336424, 111.39338971888095, 87.5067801164596 };

        public static readonly int[,] LR300AssaultRifle = { { 0, 50 }, { -11, 60 }, { -22, 67 }, { -28, 59 }, { -31, 50 }, { -29, 42 }, { -9, 38 }, { -9, 30 }, { 23, 25 }, { 36, 24 }, { 35, 13 }, { 40, 19 }, { 18, 6 }, { 0, 17 }, { -13, 6 }, { -16, 5 }, { -19, 6 }, { -34, 12 }, { -31, 2 }, { -29, 5 }, { -28, 0 }, { -21, 5 }, { -12, 13 }, { -7, 0 }, { 19, 5 }, { 3, 11 }, { 61, 0 }, { 73, 0 }, { 54, 6 }, { 0, 8 }, { 50, 0 } };
        public static readonly double[] LRControlTime = { 50.486527, 63.409837, 69.352231, 69.019084, 60.342866, 50.279209, 40.623896, 30.626204, 31.369554, 40.533283, 43.897277, 38.230196, 23.219868, 9.947927, 14.267603, 20.268351, 25.386810, 29.051251, 31.098685, 31.469423, 30.140472, 27.108869, 22.395387, 16.088652, 8.546886, 27.487437, 61.533720, 72.697228, 60.831257 };

        public static readonly int[,] SemiAssultRifle = { { 0, 75 }, { 0, 75 } };
        public static readonly double[] SemiControlTime = { 175 };

        public static readonly int[,] CustomSMG = { { -28, 52 }, { -10, 53 }, { 0, 53 }, { 11, 44 }, { 20, 45 }, { 22, 42 }, { 17, 35 }, { 7, 30 }, { -9, 27 }, { -13, 28 }, { -23, 22 }, { -21, 21 }, { -15, 24 }, { 0, 13 }, { 20, 14 }, { 16, 12 }, { 29, 19 }, { 7, 6 }, { 11, 10 }, { -4, 8 }, { -8, 13 }, { -7, 2 }, { -13, 14 }, { 0, 0 } };
        public static readonly double[] CustomSMGControlTime = { 72.942129, 66.636213, 62.974812, 61.750535, 60.935042, 57.200952, 49.164097, 38.976078, 35.006739, 37.638419, 39.187920, 36.075356, 28.171659, 21.234233, 24.358432, 28.987042, 29.927871, 26.070199, 18.119360, 13.438176, 16.856357, 19.274035, 18.320346 };

        public static readonly int[,] MP5A4 = { { 0, 43 }, { 0, 58 }, { 0, 65 }, { 25, 66 }, { 59, 58 }, { 63, 42 }, { 46, 27 }, { 3, 23 }, { -37, 19 }, { -47, 18 }, { -40, 18 }, { -8, 7 }, { 16, 12 }, { 28, 11 }, { 35, 9 }, { 34, 8 }, { 25, 6 }, { 12, 0 }, { -4, 2 }, { -6, 2 }, { -18, 0 }, { -27, 5 }, { -26, 0 }, { -27, 0 }, { -20, 0 }, { -32, 0 }, { -12, 0 }, { -25, 0 }, { -4, 0 }, { 0, 0 }, { 43, 0 }, { 0, 0 } };
        public static readonly double[] MP5A4ControlTime = { 43.441909, 58.669031, 66.411108, 71.385438, 83.641583, 79.398875, 52.763157, 21.615756, 40.987258, 52.649410, 42.242421, 15.073904, 19.158961, 29.407978, 34.560589, 33.587834, 26.295315, 12.769285, 4.207833, 10.980831, 17.070518, 21.744130, 24.917849, 26.570261, 26.693439, 25.283775, 22.339392, 17.859221, 11.842602 };

        public static readonly int[,] Thompson = { { -29, 63 }, { -12, 61 }, { 9, 61 }, { 21, 55 }, { 25, 52 }, { 21, 43 }, { 5, 32 }, { -16, 33 }, { -24, 25 }, { -24, 26 }, { -14, 21 }, { 7, 17 }, { 16, 18 }, { 23, 16 }, { 25, 17 }, { 8, 16 }, { -5, 5 }, { -13, 15 }, { -14, 8 } };
        public static readonly double[] ThompsonControlTime = { 86.598887, 78.347140, 74.408310, 73.568908, 69.211680, 57.652541, 44.231602, 43.172386, 46.847870, 43.832255, 32.594771, 25.597451, 32.269315, 36.054248, 31.898137, 20.621504, 16.997289, 22.046002, 22.690070 };

        public static readonly int[,] M92 = { { 0, 68 }, { 0, 68 } };
        public static readonly double[] M92Time = { 100 };

        public static readonly int[,] M39 = { { 0, 68 }, { 0, 68 } };
        public static readonly double[] M39ControlTime = { 200 };

        public static readonly int[,] M249 = { { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 },
        { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 },
        { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 },
        { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 },
        { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 },
        { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 },
        { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 },
        { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 },
        { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 },
        { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 } };
        public static readonly double[] M249ControlTime = { 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000, 151.250000 };
    }
}
