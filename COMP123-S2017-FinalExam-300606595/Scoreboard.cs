using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
* Name: Nirojan Kalaimannan
* Date: Aug 17,2017
* StudentID: 300606595
* Description: This is the ScoreBoard class
* Version: 0.1 - Created Scoreboard class
*/
namespace COMP123_S2017_FinalExam_300606595
{
    public class Scoreboard
    {
        //private instance variables
        private TextBox _finalScoreTextBox;
        private TextBox _scoreTextBox;
        private TextBox _timeTextBox;
        private int _score;
        private int _time;
        //public properties
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
        public TextBox ScoreTextBox {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }
        public TextBox TimeTextBox {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox=value;
            }
        }
        public Scoreboard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {

        }
        public void UpdateTime()
        {
            int timeTextBox = Convert.ToInt32(this.TimeTextBox.Text);
            Time=timeTextBox - 1;
        }
    }
}
