using System;


namespace R5T.O0025.Construction
{
    public class Demonstrations : IDemonstrations
    {
        #region Infrastructure

        public static IDemonstrations Instance { get; } = new Demonstrations();


        private Demonstrations()
        {
        }

        #endregion
    }
}
