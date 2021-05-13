using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Laba_3_2_2021
{
    class CEmblem
    {
        Color color { get; set; }
        public Color currentColor { get; set; }
        int size { get; set; }
        int x { get; set; }
        int y { get; set; }
        string name { get; set; }

        Pen pen = new Pen(Color.Blue, 2);
        PointF rotatePoint;
        double diagonal;

        public CEmblem(int x, int y, int size, string name, Color color)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            this.name = name;
            this.color = color;
            currentColor = color;
        }

        public override string ToString()
        {
            return name;
        }

        public void Hide()
        {
            currentColor = Color.White;
        }

        public void Show()
        {
            currentColor = color;
        }

        int x11 = 45;
        public void Rotate(PictureBox pictureBox)
        {
            x11 += 45;
        }

        public void Draw(PictureBox pictureBox)
        {
            Point[] points = new Point[3];
            pen.Color = currentColor;
            using (Graphics g1 = pictureBox.CreateGraphics())
            {
                rotatePoint = new PointF(x + size / 2, y + size / 2);
                Matrix myMatrix = new Matrix();
                myMatrix.RotateAt(45, rotatePoint, MatrixOrder.Append);
                g1.Transform = myMatrix;
                g1.DrawRectangle(pen, x, y, size, size);
            }
            using (Graphics g1 = pictureBox.CreateGraphics())
            {
                points[0].X = x + size / 2; points[0].Y = y;
                points[1].X = x + size / 15; points[1].Y = y + size / 4 * 3;
                points[2].X = x + size - (size / 15); points[2].Y = y + size / 4 * 3;
                g1.DrawPolygon(pen, points);

                g1.DrawEllipse(pen, x, y, size, size);
            }
        }

        public void MoveRight()
        {
            if(rotatePoint.X < (852-(diagonal*2))-150) x+=4;
            else MessageBox.Show("вихід за межі");
        }
        public void MoveLeft()
        {
            if (rotatePoint.X > diagonal+4) x-=4;
            else MessageBox.Show("вихід за межі");
        }
        public void MoveUp()
        {
            if (rotatePoint.Y > diagonal + 4) y -= 4;
            else MessageBox.Show("вихід за межі");
        }
        public void MoveDown()
        {
            if (y + size + (size - size / 2) < 510) y+=4;
            else MessageBox.Show("вихід за межі");
        }
        
        public void EndUp()
        {
            y = (size - size / 2)/2;
        }
        public void EndDown()
        {
            y = 495-size- ((size - size / 2) / 2);
        }
        public void EndLeft()
        {
            x = (size - size / 2) / 2;
        }
        public void EndRight()
        {
            x = 616 - size;
        }

        public void Enlarge()
        {
            if (rotatePoint.X < (852 - (diagonal * 2)) && rotatePoint.Y < (610 - (diagonal * 2))) size+=4;
            else MessageBox.Show("сильно велика емблемка виходить!!");
        }
        public void Reduce()
        {
            if (size > 0) size-=4;
            else MessageBox.Show("куди менше, вже й так точка!");
        }
    }
}