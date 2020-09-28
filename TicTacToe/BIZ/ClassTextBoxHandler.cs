using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class ClassTextBoxHandler : ClassCheckForWinner
    {
        /* Fields*/
        private string _gridColor;
        private string _actualSign;

        public ClassTextBoxHandler()
        {
        }

        public ClassTextBoxCollection classTextBoxCollection { get; set; } // Simple property

        /// <summary>
        /// Property returns the filed _gridColor
        /// set checks if the value is changed, if true we update actualSign so the color fits
        /// </summary>
        public string gridColor
        {
            get { return _gridColor; }
            set
            {
                if (_gridColor != value)
                {
                    actualSign = value;
                }
                Notify("gridColor");
            }
        }

        /// <summary>
        /// Returns field actualSign
        /// update the field _actualsign with the value in value
        /// </summary>
        public string actualSign
        {
            get { return _actualSign; }
            set
            {
                if (_actualSign != value)
                {
                    _actualSign = value;
                }
                Notify("actualSign");
            }
        }

        /// <summary>
        /// Method which handles new draws
        /// </summary>
        /// <param name="boxID"></param>
        /// <returns></returns>
        public bool RegTextBoxClick(string boxID)
        {
            bool bolRes = false; // initialize variabel which holds the return value
            string[] arrayKey = boxID.Split(','); // Split the parameter boxID into two elements held by our array arrayKey
            int xCord = Convert.ToInt32(arrayKey[0]); // Convert first element from arrayKey an convert to int
            int yCord = Convert.ToInt32(arrayKey[1]); // Convert first element from arrayKey an convert to int

            // Check if the chosen field is empty and 3 elements haven't been placed
            if (strSignPlacement[xCord, yCord] == "" && CheckNumberOfSigns() < 3)
            {
                // If true we the element is put in the array strSignPlacement 
                // The sign count is updated
                strSignPlacement[xCord, yCord] = actualSign;
                UpdateNumberOfSignsAdd();
                classTextBoxCollection.SetSign(boxID, actualSign); // call to the method SetSign

                //Check if three signs of the same have been placed, if true we check for a winner
                if (CheckNumberOfSigns() == 3) 
                {
                    if (CheckNewDraw(actualSign) == true)
                    {
                        bolRes = true;
                    }
                }
                // If no winner is found we update the color of the gamepad
                if (bolRes == false)
                {
                    SetColor();
                }

            }
            else
            {
                // If false we need to check if a sign needs to be removed and if true if the sign matches the content of actualSign
                // If true we remove the sign and all controlelements are updated
                if (CheckNumberOfSigns() == 3)
                {
                    if (strSignPlacement[xCord, yCord] == actualSign)
                    {
                        strSignPlacement[xCord, yCord] = "";
                        UpdateNumberOfSignsRemove();
                        classTextBoxCollection.SetSign(boxID, "");
                    }
                }
            }

            return bolRes; // return bool bolRes
        }

        /// <summary>
        /// Method checks which color the property gridColor has
        /// and changes it to fit the conditions in the if iteration
        /// </summary>
        private void SetColor()
        {
            if (gridColor == "Red")
            {
                gridColor = "Blue";
            }
            else
            {
                gridColor = "Red";
            }
        }

        /// <summary>
        /// Method needs to return how many times the sign held by actualSign appears
        /// </summary>
        /// <returns>int</returns>
        private int CheckNumberOfSigns()
        {
            int numberOfSigns = Convert.ToInt32(actualSign);

            return numberOfSigns;

            /*
             * 
             * return = res(the number of times the value of actualSign appears)
             */
        }

        /// <summary>
        /// Method needs to increase value of either intX or intO based on actualSign
        /// </summary>
        private void UpdateNumberOfSignsAdd()
        {

        }

        /// <summary>
        /// Method needs to decrease value of either intX or intO based on actualSign
        /// </summary>
        private void UpdateNumberOfSignsRemove()
        {

        }

        /// <summary>
        /// This method initializes the game, so a new game can be begin 
        /// </summary>
        public void ResetAll()
        {
            initializeArray();
            classTextBoxCollection.InitializeTextBox();
            gridColor = "Blue";
            intO = 0;
            intX = 0;
        }

    }
}
