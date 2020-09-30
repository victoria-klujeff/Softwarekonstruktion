using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BIZ
{
    public class ClassCheckForWinner : ClassCountDrawAndRegister
    {
        public ClassCheckForWinner()
        {
        }

        /// <summary>
        /// Method which checks if the placement of the signs equals a winning placement 
        /// Method returns a bool true if the placement is a winner and false if not
        /// Recieves a paramter of string which we used to determine the signs that have been placed
        /// Create an array which we set equal to the eight possibillities of winning placement 
        /// We run through a foreach to check if strfacit[i] is a match to the strWinner, we run through the forloop till we find a match or till our counter is eqaul to or less than 7
        /// Each time we run through the loop we use an if to check if the string containing the combination from GUI matches the strFacit[i]
        /// We return the result
        /// </summary>
        /// <param name="strSign"></param>
        /// <returns></returns>
        protected bool CheckNewDraw(string strSign)
        {
            bool bolRes = false;
            string strWinner = strSign + strSign + strSign;
            string[] strFacit = new string[8];

            strFacit[0] = strSignPlacement[0, 0] + strSignPlacement[0, 1] + strSignPlacement[0, 2];
            strFacit[1] = strSignPlacement[1, 0] + strSignPlacement[1, 1] + strSignPlacement[1, 2];
            strFacit[2] = strSignPlacement[2, 0] + strSignPlacement[2, 1] + strSignPlacement[2, 2];
            strFacit[3] = strSignPlacement[0, 0] + strSignPlacement[1, 0] + strSignPlacement[2, 0];
            strFacit[4] = strSignPlacement[0, 1] + strSignPlacement[1, 1] + strSignPlacement[2, 1];
            strFacit[5] = strSignPlacement[0, 2] + strSignPlacement[1, 2] + strSignPlacement[2, 2];
            strFacit[6] = strSignPlacement[0, 0] + strSignPlacement[1, 1] + strSignPlacement[2, 2];
            strFacit[7] = strSignPlacement[0, 2] + strSignPlacement[1, 1] + strSignPlacement[2, 0];

            for (int i = 0; i <= 7; i++)
            {
                if (strFacit[i] == strWinner)
                {
                    bolRes = true;
                    UpdateScore(strSign);
                }
            }
            return bolRes;
        }

        /// <summary>
        /// Method which recieves a parameter of string
        /// If inSign matches X we add to the intscoreCountX and if not we add to the intscoreCountO
        /// </summary>
        /// <param name="inSign"></param>
        private void UpdateScore(string inSign)
        {
            if (inSign == "X")
            {
                intScoreCountX++;
            }
            else
            {
                intScoreCountO++;
            }
        }
    }
}
