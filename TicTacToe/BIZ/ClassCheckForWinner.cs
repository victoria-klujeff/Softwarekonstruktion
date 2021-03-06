﻿using System;
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
        /// Recieves a paramter of string which we used to determine which sign we are checking X or O
        /// Create an array which we set equal to the content of the textboxes
        /// The for loop lets us run through till the condiotion in the if is met or till we have run through 8 times
        /// We use the i counter to determine which strFacit to check for a match
        /// Each time we run through the loop we use an if to check if strWinner(based on which sign has just been placed) matches the strFacit[i]
        /// We return bolRes
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
        /// Method which recieves a parameter of string(The sign that has just been placed)
        /// If the content of inSign is X we add to the intscoreCountX and if not we add to the intscoreCountO
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
