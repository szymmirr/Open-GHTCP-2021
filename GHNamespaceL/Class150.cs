namespace GHNamespaceL
{
    public class Class150
    {
        // Appears to be a qb int array (like for a song)
        private static readonly short[] Short0 =
        {
            0,
            -32763,
            -32753,
            10,
            -32741,
            30,
            20,
            -32751,
            -32717,
            54,
            60,
            -32711,
            40,
            -32723,
            -32729,
            34,
            -32669,
            102,
            108,
            -32663,
            120,
            -32643,
            -32649,
            114,
            80,
            -32683,
            -32673,
            90,
            -32693,
            78,
            68,
            -32703,
            -32573,
            198,
            204,
            -32567,
            216,
            -32547,
            -32553,
            210,
            240,
            -32523,
            -32513,
            250,
            -32533,
            238,
            228,
            -32543,
            160,
            -32603,
            -32593,
            170,
            -32581,
            190,
            180,
            -32591,
            -32621,
            150,
            156,
            -32615,
            136,
            -32627,
            -32633,
            130,
            -32381,
            390,
            396,
            -32375,
            408,
            -32355,
            -32361,
            402,
            432,
            -32331,
            -32321,
            442,
            -32341,
            430,
            420,
            -32351,
            480,
            -32283,
            -32273,
            490,
            -32261,
            510,
            500,
            -32271,
            -32301,
            470,
            476,
            -32295,
            456,
            -32307,
            -32313,
            450,
            320,
            -32443,
            -32433,
            330,
            -32421,
            350,
            340,
            -32431,
            -32397,
            374,
            380,
            -32391,
            360,
            -32403,
            -32409,
            354,
            -32477,
            294,
            300,
            -32471,
            312,
            -32451,
            -32457,
            306,
            272,
            -32491,
            -32481,
            282,
            -32501,
            270,
            260,
            -32511,
            -31997,
            774,
            780,
            -31991,
            792,
            -31971,
            -31977,
            786,
            816,
            -31947,
            -31937,
            826,
            -31957,
            814,
            804,
            -31967,
            864,
            -31899,
            -31889,
            874,
            -31877,
            894,
            884,
            -31887,
            -31917,
            854,
            860,
            -31911,
            840,
            -31923,
            -31929,
            834,
            960,
            -31803,
            -31793,
            970,
            -31781,
            990,
            980,
            -31791,
            -31757,
            1014,
            1020,
            -31751,
            1000,
            -31763,
            -31769,
            994,
            -31837,
            934,
            940,
            -31831,
            952,
            -31811,
            -31817,
            946,
            912,
            -31851,
            -31841,
            922,
            -31861,
            910,
            900,
            -31871,
            640,
            -32123,
            -32113,
            650,
            -32101,
            670,
            660,
            -32111,
            -32077,
            694,
            700,
            -32071,
            680,
            -32083,
            -32089,
            674,
            -32029,
            742,
            748,
            -32023,
            760,
            -32003,
            -32009,
            754,
            720,
            -32043,
            -32033,
            730,
            -32053,
            718,
            708,
            -32063,
            -32189,
            582,
            588,
            -32183,
            600,
            -32163,
            -32169,
            594,
            624,
            -32139,
            -32129,
            634,
            -32149,
            622,
            612,
            -32159,
            544,
            -32219,
            -32209,
            554,
            -32197,
            574,
            564,
            -32207,
            -32237,
            534,
            540,
            -32231,
            520,
            -32243,
            -32249,
            514
        };

        public static short smethod_0(byte byte0, short short1)
        {
            short1 = (short) (short1 << 8 ^ Short0[(short1 >> 8 ^ byte0) & 255]);
            return short1;
        }
    }
}