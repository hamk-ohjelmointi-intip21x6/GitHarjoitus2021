namespace GitHarjoitus2021
{
    public class Laskin
    {


        public int Summa(int luku1, int luku2)
        {
            return luku1 + luku2;
        } 

        public int JakoJaannos(int luku1, int luku2)
        {
            return luku1 % luku2;
        }

        public int Erotus(int luku1, int luku2)
        {
            return luku1 - luku2;
        }

        /// <summary>
        /// Tulo on kertolaskun  tulos.
        /// </summary>
        /// <param name="luku1"></param>
        /// <param name="luku2"></param>
        /// <returns></returns>
        public int Tulo(int luku1, int luku2)
        {
            return luku1 * luku2;
        } 

        public int JakoLasku(int luku1, int luku2)
        {
            return luku1 / luku2;
        } 

    }
}
