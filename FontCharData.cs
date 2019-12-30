/*
    Copyright (C) 2019 Antoine Guilbaud (IronPowerTga)
   Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:
  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow
{
    public class FontCharData
    {
        public int OffSetX { get; set; }
        public int OffSetY { get; set; }
        public int AdvanceX { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle SourceRectangle
        {
            get => new Rectangle(X, Y, Width, Height);
            set
            {
                X = value.X;
                Y = value.Y;
                Width = value.Width;
                Height = value.Height;
            }
        }
        public Point Position
        {
            get => new Point(X, Y);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }
        public Point OffSet
        {
            get => new Point(OffSetX, OffSetY);
            set
            {
                OffSetX = value.X;
                OffSetY = value.Y;
            }
        }

        public FontCharData(Point offset, int xAdvance, Rectangle sourceRectangle)
        {
            OffSet = offset;
            AdvanceX = xAdvance;
            SourceRectangle = sourceRectangle;
        }
    }
}
