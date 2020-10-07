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

        /* Constructor with our initialized properties*/

        public ClassTextBoxHandler()
        {
            gridColor = "Red";
            actualSign = "X";
            classTextBoxCollection = new ClassTextBoxCollection();
        }

        public ClassTextBoxCollection classTextBoxCollection { get; set; } // Simple property

        /// <summary>
        /// Property returns the field _gridColor
        /// set checks if the value is changed, if true we update actualSign so the color fits
        /// </summary>
        public string gridColor
        {
            get { return _gridColor; }
            set
            {
                if (_gridColor != value)
                {
                    _gridColor = value;
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
                    SetSign();
                    //SetSign();
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
        private void SetSign()
        {
            if (gridColor == "Red")
            {
                gridColor = "Blue";
                actualSign = "O";
            }
            else
            {
                gridColor = "Red";
                actualSign = "X";
            }
        }

        //private void Set()
        //{
        //    if (gridColor == "Red")
        //    {
        //        actualSign = "X";
        //    }
        //    else
        //    {
        //        actualSign = "O"; 
        //    }
        //}
        /// <summary>
        /// Method needs to return how many times the sign held by actualSign appears
        /// </summary>
        /// <returns>int</returns>
        private int CheckNumberOfSigns()
        {
            int res = 0;
            if (actualSign == "X")
            {
                res = intX;
            }
            else
            {
                res = intO;
            }

            return res;
        }

        /// <summary>
        /// Method needs to increase value of either intX or intO based on actualSign
        /// </summary>
        private void UpdateNumberOfSignsAdd()
        {
            if (actualSign == "X")
            {
                intX++;
            }
            else
            {
                intO++;
            }
        }

        /// <summary>
        /// Method needs to decrease value of either intX or intO based on actualSign
        /// </summary>
        private void UpdateNumberOfSignsRemove()
        {
            if (actualSign == "X")
            {
                intX--;
            }
            else
            {
                intO--;
            }
        }

        /// <summary>
        /// This method initializes the game, so a new game can be begin 
        /// We call the methods initializeArray and initializeTextbox to reset all values.
        /// We initialize our properties gridColor and actualSign
        /// 
        /// </summary>
        public void ResetAll()
        {
            initializeArray();
            classTextBoxCollection.InitializeTextBox();
            gridColor = "Red";
            actualSign = "X";
            intO = 0;
            intX = 0;
        }

    }
}
