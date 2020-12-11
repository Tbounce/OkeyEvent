using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      pbPlay1.Image = null;
      pbPlay2.Image = null;
      pbPlay3.Image = null;
      pbBoard1.Image = null;
      pbBoard2.Image = null;
      pbBoard3.Image = null;
      pbBoard4.Image = null;
      pbBoard5.Image = null;
      pbB1.Visible = true;
      pbB2.Visible = true;
      pbB3.Visible = true;
      pbB4.Visible = true;
      pbB5.Visible = true;
      pbB6.Visible = true;
      pbB7.Visible = true;
      pbB8.Visible = true;
      pbR1.Visible = true;
      pbR2.Visible = true;
      pbR3.Visible = true;
      pbR4.Visible = true;
      pbR5.Visible = true;
      pbR6.Visible = true;
      pbR7.Visible = true;
      pbR8.Visible = true;
      pbG1.Visible = true;
      pbG2.Visible = true;
      pbG3.Visible = true;
      pbG4.Visible = true;
      pbG5.Visible = true;
      pbG6.Visible = true;
      pbG7.Visible = true;
      pbG8.Visible = true;
    }

    private void addToCardboard(PictureBox pictureBox)
    {
      pictureBox.Visible = false;

      if (pbBoard1.Image == null)
      {
        pbBoard1.Image = pictureBox.Image;
      }else if(pbBoard2.Image == null)
      {
        pbBoard2.Image = pictureBox.Image;
      }
      else if (pbBoard3.Image == null)
      {
        pbBoard3.Image = pictureBox.Image;
      }
      else if (pbBoard4.Image == null)
      {
        pbBoard4.Image = pictureBox.Image;
      }
      else if (pbBoard5.Image == null)
      {
        pbBoard5.Image = pictureBox.Image;
      }
      else {
        pictureBox.Visible = true;
      } 


    }
    private void pbR1_Click(object sender, EventArgs e)
    {
      addToCardboard(pbR1);
      //pbR1.Visible = false;
    }

    private void pbR2_Click(object sender, EventArgs e)
    {
      addToCardboard(pbR2);
      //pbR2.Visible = false;

    }

    private void pbR3_Click(object sender, EventArgs e)
    {
      addToCardboard(pbR3);
      //pbR3.Visible = false;
    }

    private void pbR4_Click(object sender, EventArgs e)
    {
      addToCardboard(pbR4);
      //pbR4.Visible = false;
    }
    private void pbR5_Click(object sender, EventArgs e)
    {
      addToCardboard(pbR5);
      //pbR5.Visible = false;
    }

    private void pbR6_Click(object sender, EventArgs e)
    {
      addToCardboard(pbR6);
      //pbR6.Visible = false;
    }

    private void pbR7_Click(object sender, EventArgs e)
    {
      addToCardboard(pbR7);
      //pbR7.Visible = false;
    }

    private void pbR8_Click(object sender, EventArgs e)
    {
      addToCardboard(pbR8);
      //pbR8.Visible = false;
    }

    private void pbB1_Click(object sender, EventArgs e)
    {
      addToCardboard(pbB1);
      //pbB1.Visible = false;
    }

    private void pbB2_Click(object sender, EventArgs e)
    { 
      addToCardboard(pbB2);
      //pbB2.Visible = false;
    }

    private void pbB3_Click(object sender, EventArgs e)
    {
      addToCardboard(pbB3);
      //pbB3.Visible = false;
    }

    private void pbB4_Click(object sender, EventArgs e)
    {
      addToCardboard(pbB4);
      //pbB4.Visible = false;
    }

    private void pbB5_Click(object sender, EventArgs e)
    {
      addToCardboard(pbB5);
      //pbB5.Visible = false;
    }

    private void pbB6_Click(object sender, EventArgs e)
    {
      addToCardboard(pbB6);
      //pbB6.Visible = false;
    }

    private void pbB7_Click(object sender, EventArgs e)
    {
      addToCardboard(pbB7);
      //pbB7.Visible = false;
    }

    private void pbB8_Click(object sender, EventArgs e)
    {
      addToCardboard(pbB8);
      //pbB8.Visible = false;
    }

    private void pbG1_Click(object sender, EventArgs e)
    {
      addToCardboard(pbG1);
      //pbG1.Visible = false;
    }

    private void pbG2_Click(object sender, EventArgs e)
    {
      addToCardboard(pbG2);
      //pbG2.Visible = false;
    }

    private void pbG3_Click(object sender, EventArgs e)
    {
      addToCardboard(pbG3);
     // pbG3.Visible = false;
    }

    private void pbG4_Click(object sender, EventArgs e)
    {
      addToCardboard(pbG4);
     // pbG4.Visible = false;
    }

    private void pbG5_Click(object sender, EventArgs e)
    {
      addToCardboard(pbG5);
      //pbG5.Visible = false;
    }

    private void pbG6_Click(object sender, EventArgs e)
    {
      addToCardboard(pbG6);
      //pbG6.Visible = false;
    }

    private void pbG7_Click(object sender, EventArgs e)
    {
      addToCardboard(pbG7);
      //pbG7.Visible = false;
    }

    private void pbG8_Click(object sender, EventArgs e)
    {
      addToCardboard(pbG8);
      //pbG8.Visible = false;
    }

    private void pbBoard1_Click(object sender, EventArgs e)
    {
      moveCards(pbBoard1, e);

    }

    private void moveCards(PictureBox box, EventArgs e)
    {
      PictureBox temp = new PictureBox();
      MouseEventArgs me = (MouseEventArgs)e;
      System.Diagnostics.Debug.WriteLine(me.Button.ToString());

      temp.Image = box.Image;

      if (me.Button.ToString() == "Right")
      {
        box.Image = null;
      }
      else
      {
        box.Image = null;
        if (pbPlay1.Image == null)
        {
          pbPlay1.Image = temp.Image;
        }else if(pbPlay2.Image == null)
        {
          pbPlay2.Image = temp.Image;
        }else if(pbPlay3.Image == null)
        {
          pbPlay3.Image = temp.Image;
        }
        else
        {
          box.Image = temp.Image;
        }

      }

    }

    private void pbBoard2_Click(object sender, EventArgs e)
    {
      moveCards(pbBoard2, e);
    }

    private void pbBoard3_Click(object sender, EventArgs e)
    {
      moveCards(pbBoard3, e);
    }

    private void pbBoard4_Click(object sender, EventArgs e)
    {
      moveCards(pbBoard4, e);
    }

    private void pbBoard5_Click(object sender, EventArgs e)
    {
      moveCards(pbBoard5, e);
    }

    private void pbPlay1_Click(object sender, EventArgs e)
    {
      removeCards(pbPlay1);
    }
    private void removeCards(PictureBox pictureBox)
    {
      if (pbBoard1.Image == null)
      {
        pbBoard1.Image = pictureBox.Image;
      }
      else if (pbBoard2.Image == null)
      {
        pbBoard2.Image = pictureBox.Image;
      }
      else if (pbBoard3.Image == null)
      {
        pbBoard3.Image = pictureBox.Image;
      }
      else if (pbBoard4.Image == null)
      {
        pbBoard4.Image = pictureBox.Image;
      }
      else if (pbBoard5.Image == null)
      {
        pbBoard5.Image = pictureBox.Image;
      }
      else
      {
      }
      pictureBox.Image = null;
    }

    private void pbPlay2_Click(object sender, EventArgs e)
    {
      removeCards(pbPlay2);
    }

    private void pbPlay3_Click(object sender, EventArgs e)
    {
      removeCards(pbPlay3);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      pbPlay1.Image = null;
      pbPlay2.Image = null;
      pbPlay3.Image = null;
    }
  }
}
