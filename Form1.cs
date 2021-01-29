using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            this.richTextBox1.SelectionFont = fontDialog1.Font;
            this.richTextBox1.SelectionColor = fontDialog1.Color;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            string url = openFileDialog1.FileName;
            if(url.Contains(".txt"))
            {
                this.richTextBox1.LoadFile(url, RichTextBoxStreamType.PlainText);
                }
            else
            {
                return;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|WORD文档(*.doc)|*.doc";
            this.saveFileDialog1.ShowDialog();
            string stvsave = this.saveFileDialog1.FileName;
            if(stvsave.Trim()=="")
            {
                return;    
            }
            else
            {
                this.richTextBox1.SaveFile(stvsave, RichTextBoxStreamType.RichNoOleObjs);
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void 复制CToolStripButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void 粘贴PToolStripButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void 剪切UToolStripButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void 撤消UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void 恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void 重复RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void 居左ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();

            this.richTextBox1.SelectionFont=this.fontDialog1.Font;

            this.richTextBox1.SelectionColor = this.fontDialog1.Color;

        }

        private void 字体ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();

            this.richTextBox1.SelectionFont = this.fontDialog1.Font;

            this.richTextBox1.SelectionColor = this.fontDialog1.Color;

        }

        private void 字体颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionColor = this.fontDialog1.Color;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //this.contextMenuStrip1.Show();
        }

        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|WORD文档(*.doc)|*.doc";
            this.saveFileDialog1.ShowDialog();
            string stvsave = this.saveFileDialog1.FileName;
            if (stvsave.Trim() == "")
            {
                return;
            }
            else
            {
                this.richTextBox1.SaveFile(stvsave, RichTextBoxStreamType.RichNoOleObjs);
            }
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt";
            string url = openFileDialog1.FileName;
            if (url.Contains(".txt"))
            {
                this.richTextBox1.LoadFile(url, RichTextBoxStreamType.PlainText);
            }
            else
            {
                return;
            }
        }
    }
}
