using System;

namespace GamePieces
{
    /**
     * This class will be for an object that will generate a random fixed number, eventually we will add displays etc
     */
    public class Die
    {
        /**
         * By default all dice will use the same Random object, but we will allow for indivudal dice to have their own Random object if they so choose.
         */
        static private Random gRand = null;

        private static Random GetRandom()
        {
            if (null == gRand)
            {
                gRand = new Random();
            }
            return gRand;
        }

        public int NumSides { get; private set; }
        private Random Rand { get; set; }

        /**
         * Initially our constructor will take a single parameter, the number of sides that it has
         */
        public Die(int numSides)
        {
            NumSides = numSides;
            Rand = GetRandom();
        }
        public Die(int numSides, int seed)
        {
            NumSides = numSides;
            Rand = new Random(seed);
        }

        /**
         * Get a private time-based random number generator object
         */
        public void ReseedRandomGenerator()
        {
            Rand = new Random();
        }

        /**
         * Get a private time-based random number generator object
         */
        public void ReseedRandomGenerator(int seed)
        {
            Rand = new Random(seed);
        }

        public int Roll()
        {
            int roll = 1 + (Rand.Next() % NumSides);

            return roll;
        }

    }
}
