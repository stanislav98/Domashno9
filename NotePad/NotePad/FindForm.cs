﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        private void FindForm_Load(object sender, EventArgs e)
        {

        }

        public RichTextBoxFinds FindCondition
        {
            get
            {
                if (cbMatchCase.Checked && cbMatchWhole.Checked)
                {
                    return RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord;
                }
                if (cbMatchCase.Checked)
                {
                    return RichTextBoxFinds.MatchCase;
                }
                if (cbMatchWhole.Checked)
                {
                    return RichTextBoxFinds.WholeWord;
                }
                return RichTextBoxFinds.None;
            }
        }

        public string FindText
        {
            get { return txtFind.Text; }
            set { txtFind.Text = value; }
        }

    }
}
