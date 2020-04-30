using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace пирамида
{
    class Piramida
    {
        int index;
        int count;
        List<Wheel> TypeCircle;
        int x;
        int y;
        int y1;
        int x1;
        public Piramida(int index)
        {
            this.index = index;
           
            TypeCircle = new List<Wheel>();
           
           
        }
       
        public int Count
        {
            get
            { return count; }
            
        }
        public void DrawWhels(List<Wheel> Wheels, Graphics gr, Panel p)
        {int otstyp = 35;
        if (Wheels.Count != 0)
        {
            for (int i = 1; i <= Wheels.Count; i++)
            {
                gr.FillEllipse(new SolidBrush(Color.Black), x - (Wheels[i - 1].Type * (p.Width / 6 - otstyp) / 3), (p.Height / 2 + p.Height / 4) - i * (p.Height / 2 + p.Height / 4 - y) / 4, (x - (x - (Wheels[i - 1].Type * (p.Width / 6 - otstyp) / 3)))*2,(y1-y)/4);
            }
        }
        }
        public void AddWheel(Wheel l)
        {
            TypeCircle.Add(l);
            count++;
        }
        public void DeleteWheel()
        
        {
            TypeCircle.RemoveAt(TypeCircle.Count() -1);
            count--;
        }
        public Wheel Wheelss()
        {
            
            
                return TypeCircle.Last();
            
            
        }
        public void DrowItSelf (Graphics gr, Panel p)
        {
            gr = p.CreateGraphics();
            int otstyp = 30;
            x = (p.Width / 4)*index;
                y = p.Height / 2 - p.Height / 4;
                y1 = p.Height / 2 + p.Height / 4;
                x1 = (x - (p.Width / 6 - otstyp));
            if (index == 1)
            {
                
                gr.DrawLine(new Pen(Color.Black, 2), x, y, x, p.Height / 2 + p.Height / 4);
                gr.DrawLine(new Pen(Color.Black, 2), x - (p.Width / 6 - otstyp), p.Height / 2 + p.Height / 4, x + (p.Width / 6 - otstyp), p.Height / 2 + p.Height / 4);
            }
            if (index == 2)
            {
               
                gr.DrawLine(new Pen(Color.Black, 2), x, y, x, p.Height / 2 + p.Height / 4);
                gr.DrawLine(new Pen(Color.Black, 2), x - (p.Width / 6 - otstyp), p.Height / 2 + p.Height / 4, x + (p.Width / 6 - otstyp), p.Height / 2 + p.Height / 4);
            }
            if (index == 3)
            {
                
                gr.DrawLine(new Pen(Color.Black, 2), x, y, x, p.Height / 2 + p.Height / 4);
                gr.DrawLine(new Pen(Color.Black, 2), x - (p.Width / 6 - otstyp), p.Height / 2 + p.Height / 4, x + (p.Width / 6 - otstyp), p.Height / 2 + p.Height / 4);
            }
            DrawWhels(TypeCircle, gr, p);
        }
        public void DrawPiramida( Graphics gr, int Weight, int Height, int n)
        {
            x = Weight / 2;
            y = Height / 2 + Height / 4 + Height/6;
            y1 = Height / 2 - Height / 4;
            x1 = Weight / 2 - Weight / 4 - Weight / 6;
            gr.DrawLine(new Pen(Color.Black, 3), x, y1, x, y);
            gr.DrawLine(new Pen(Color.Black, 3), x1, y, Weight / 2 + Weight / 4 + Weight / 6, y);
           int HeightWheel = (y-y1)/n;
            int WeightWheel = (x-x1)/n;
            for (int i = 0; i < TypeCircle.Count(); i++)
            {
                
                gr.DrawEllipse(new Pen(Color.Black, 3), (x - (WeightWheel * TypeCircle[i].Type)), y - (HeightWheel * (i+1)), WeightWheel * TypeCircle[i].Type * 2, HeightWheel);
                gr.DrawEllipse(new Pen(TypeCircle[i].ClRR, 3), (x - (WeightWheel * TypeCircle[i].Type)), y - (HeightWheel * (i + 1)), WeightWheel * TypeCircle[i].Type * 2, HeightWheel);
            }
        }
        public void DeleteAllWheels()
        {
            if (TypeCircle.Count() != 0)
            {
                for (int i = TypeCircle.Count() - 1; i >= 0; i--)
                {
                    TypeCircle.RemoveAt(i);
                }
            }
        }

         
       
    }
}
