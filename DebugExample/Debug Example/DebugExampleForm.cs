﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Debug_Example
{
    public partial class DebugExampleForm : Form
    {
        private const string WINFORM_EVENTS = "WinForm Events";

        public DebugExampleForm()
        {
                        Debug.AutoFlush = true;
            InitializeComponent();
            SetupListBoxTraceListener();
        }

        private void SetupListBoxTraceListener()
        {
            ListBoxTraceListener listener = new ListBoxTraceListener(lbDebug);
            Debug.Listeners.Add(new TextWriterTraceListener("Log.txt"));
            Debug.Listeners.Add(listener);
            Debug.WriteLine("Textbox has been added to listeners");
        }

        private void btnAssertSuccess_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.Name = "test";
            string threadName = System.Threading.Thread.CurrentThread.Name;
            int threadID = System.Threading.Thread.CurrentThread.ManagedThreadId;

            int i = 0;
            i = 5;
            TestI(i);
            i = 42;


            Debug.Write("Testing assertion");
            Debug.Assert(true, "Assert successfull", "More details");
            Debug.WriteLine("Assertion has been tested");
        }

        private void TestI(int i)
        {
            i = 4;
            test2();
            i = 3;
            i = 6;
        }

        void test2()
        {
            int v = 0;
            v = 2;
        }

        private void btnAssertFail_Click(object sender, EventArgs e)
        {
            Debug.Assert(false, "Assert failed");
            Debug.Fail("This assertion always fails", "Some details here");
        }

        private void btnConditionalAssert_Click(object sender, EventArgs e)
        {
            bool condition = cbConditionalAssert.Checked;
            Debug.Assert(condition, "Assertion fails, checkbox is not checked", cbConditionalAssert.ToString());
        }

        private void btnSendDebugMessage_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(tbDebugMessage.Text);
        }

        private void btnSendConditionnalMessage_Click(object sender, EventArgs e)
        {
            bool condition = cbConditionalAssert.Checked;
            Debug.WriteLineIf(condition, tbDebugMessage.Text);
        }

        private void DebugExampleForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Form load event", WINFORM_EVENTS);
        }

        private void DebugExampleForm_Shown(object sender, EventArgs e)
        {
            Debug.WriteLine("Form shown event", WINFORM_EVENTS);
        }

        private void DebugExampleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("Form closing event", WINFORM_EVENTS);
        }

        private void DebugExampleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine("Form closed event", WINFORM_EVENTS);
        }

        private void tbDebugMessage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Debug.WriteLine($"tbDebugMessage.PreviewKeyDown : {e.KeyCode} ({e.KeyValue})", WINFORM_EVENTS);
        }

        //private int countPaintEvent = 0;
        private void DebugExampleForm_Paint(object sender, PaintEventArgs e)
        {
            //Debug.WriteLine($"Form paint event {countPaintEvent++}", WINFORM_EVENTS);
        }

        private void btnRaiseExceptions_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(tbDebugMessage.Text);
                ExceptionRaiser exceptionRaiser = new ExceptionRaiser(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
