// Author: Jonathan Spalding
// Assignment: Project 04
// Instructor: Roger deBry
// Class: CS 1400
// Date Written: 2/13/2016
//
// I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I a found in violation of this policy.
//-----------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The exitToolStripMenuItem1_Click Method
        // Purpose: Close the program when you click Exit
        // Paraeters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The aboutToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding\nCS1400\nProject 04");
        }
        // The CalculateButton_Click Method
        // Purpose: convert all code into doubles, do the math with the method, convert back into string, and output in the SideC box.
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // State all Constants
            const double STRAIGHT_ANGLE = 180;
            // Convert all input boxes from a string to a double.
            double SideALength = double.Parse(SideA.Text);
            double SideBLength = double.Parse(SideB.Text);
            double AngleCDegree = double.Parse(AngleC.Text);
            // convert the angle of "AngleC" to an actual degree and state it in its own variable.
            double AngleCRadians = AngleCDegree * Math.PI / STRAIGHT_ANGLE;
            // call the clear method and state it in its own variable 
            double SideCLength = calcLengthOfSideC(SideALength, SideBLength, AngleCRadians);
            // convert the length of side C into a string and assign to another variable.
            string outStr = $"{SideCLength:f}";
            // display output in final output box.
            SideC.Text = outStr;

            // call the methods for both Angle A and Angle B. Extra Credit
            double AngleADegree = calcAngleA(SideALength, SideBLength, SideCLength);
            double AngleBDegree = calcAngleB(SideALength, SideBLength, SideCLength);
            // convert angles A and C to strings. Extra Credit
            string outStrA = $"{AngleADegree:f}";
            String outStrB = $"{AngleBDegree:f}";
            // display output for angles of B and C. Extra Credit
            AngleA.Text = outStrA;
            AngleB.Text = outStrB;

        }
        // The ClearButton_Click Method
        // purpose: Clear the textboxes, and put the cursor back in the first text box
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // clear each text box.
            SideA.Clear();
            SideB.Clear();
            AngleC.Clear();
            SideC.Clear();
            AngleA.Clear();
            AngleB.Clear();
            // put the cursor back in the first text box.
            SideA.Select();
        }
        // The calcLengthOfSideC Method
        // Purpose: calculate the side of C from the given inputs of lengths of side a and b, and Angle C.
        // Parameters: double SideALength, double SideBLength, double AngleCRadians
        // Returns: double SideCLengthSquared
        static double calcLengthOfSideC(double SideALength, double SideBLength, double AngleCRadians)
        {
            // Use the Law of Cosigns to find the length of C Squared: c2 = a2 + b2 - 2abCos(C)
            double SideCLengthSquared = Math.Sqrt(SideALength * SideALength + SideBLength * SideBLength - 2 * SideALength * SideBLength * Math.Cos(AngleCRadians));
            // return Result
            return SideCLengthSquared;
        }
        // Extra Credit Methods
        //
        // The calcAngleA Method
        // Purpose: Find the angle of AngleA
        // Parameters: double SideALength, double SideBLength, double SideCLength
        // Returns: double AngleA
        static double calcAngleA(double SideALength, double SideBLength, double SideCLength)
        {
            // Use the law of Cosines to find AngleA
            double AngleA = ((SideCLength * SideCLength) + (SideBLength * SideBLength) - (SideALength * SideALength)) / (2 * SideCLength * SideBLength);
            // Multiply the Inverse Cosine (cos^-1()) by 180/PI to convert it from radians to a percentage.
            AngleA = Math.Acos(AngleA) * 180 / Math.PI;
            // Return Result
            return AngleA;
        }
        // The calcAngleB Method
        // Purpose: Find the angle of AngleB
        // Parameters: double SideALength, double SideBLength, double SideCLength
        // Returns: double AngleB
        static double calcAngleB(double SideALength, double SideBLength, double SideCLength)
        {
            double AngleB = (SideALength * SideALength + SideCLength * SideCLength - SideBLength * SideBLength) / (2 * SideALength * SideCLength);
            // Multiply the Inverse Cosine (cos^-1()) by 180/PI to convert it from radians to a percentage.
            AngleB = Math.Acos(AngleB) * 180 / Math.PI;
            // Return Result
            return AngleB;
        }
    }
}
