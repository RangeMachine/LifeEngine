/**
 * LifeEngine is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * LifeEngine is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see <http://www.gnu.org/licenses/>.
 *
 * Copyright © 2017 RangeMachine
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace LifeEngine
{
    public sealed partial class LifeGrid : UserControl
    {
        private bool[] m_gridStates = new bool[100 * 100];
        private bool[] m_historyStates = new bool[100 * 100];

        private bool m_gridLinesVisible;
        private float m_gridLineThickness;

        private int m_columns;
        private int m_rows;

        private Color m_cellColorAlive;
        private Color m_cellColorDead;
        private Color m_cellColorHistory;

        public Color CellColorAlive
        {
            get
            {
                return m_cellColorAlive;
            }
            set
            {
                m_cellColorAlive = value;
                Invalidate();
            }
        }

        public Color CellColorDead
        {
            get
            {
                return m_cellColorDead;
            }
            set
            {
                m_cellColorDead = value;
                Invalidate();
            }
        }

        public Color CellColorHistory
        {
            get
            {
                return m_cellColorHistory;
            }
            set
            {
                m_cellColorHistory = value;
                Invalidate();
            }
        }

        public int Columns
        {
            get
            {
                return m_columns;
            }
            set
            {
                m_columns = value;
                CreateGrid();
            }
        }

        public int Rows
        {
            get
            {
                return m_rows;
            }
            set
            {
                m_rows = value;
                CreateGrid();
            }
        }

        public bool LinesVisible
        {
            get
            {
                return m_gridLinesVisible;
            }
            set
            {
                m_gridLinesVisible = value;
                Invalidate();
            }
        }

        public float LinesSize
        {
            get
            {
                return m_gridLineThickness;
            }
            set
            {
                m_gridLineThickness = value;
                Invalidate();
            }
        }
        
        public LifeGrid() : 
            this(100, 100, Color.Black, Color.White, Color.Gray)
        {
        }

        public LifeGrid(int columns, int rows) : 
            this(columns, rows, Color.Black, Color.White, Color.Gray)
        {
        }

        public LifeGrid(int columns, int rows, Color aliveColor, Color deadColor, Color historyColor)
        {
            InitializeComponent();

            DoubleBuffered = true;
            TabStop = false;

            m_columns = columns;
            m_rows = rows;
            m_gridLineThickness = 1;
            m_gridLinesVisible = true;

            m_cellColorAlive = aliveColor;
            m_cellColorDead = deadColor;
            m_cellColorHistory = historyColor;
        }
        
        public void UpdateGrid(bool[] gridStates, bool[] historyStates)
        {
            if (gridStates.Length == m_gridStates.Length)
            {
                gridStates.CopyTo(m_gridStates, 0);
                Invalidate();
            }
            else
            {
                throw new InvalidOperationException("Cell grid sizes do not match.");
            }

            if (historyStates.Length == m_historyStates.Length)
            {
                historyStates.CopyTo(m_historyStates, 0);
                Invalidate();
            }
            else
            {
                throw new InvalidOperationException("History grid sizes do not match.");
            }
        }
        
        private void CreateGrid()
        {
            m_gridStates = new bool[m_columns * m_rows];
            m_historyStates = new bool[m_columns * m_rows];
            Invalidate();
        }
        
        private void LifeGridPaint(object sender, PaintEventArgs e)
        {
            float cellWidth = (float)Width / m_columns;
            float cellHeight = (float)Height / m_rows;
            float line = 0;

            if (m_gridLinesVisible)
                line = m_gridLineThickness;

            Graphics painter = e.Graphics;
            SolidBrush aliveBrush = new SolidBrush(m_cellColorAlive);
            SolidBrush deadBrush = new SolidBrush(m_cellColorDead);
            SolidBrush historyBrush = new SolidBrush(m_cellColorHistory);

            painter.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, Width, Height));

            for (int y = 0; y < m_rows; y++)
            {
                for (int x = 0; x < m_columns; x++)
                {
                    if (m_gridStates[x + y * m_columns])
                    {
                        painter.FillRectangle(
                            aliveBrush, x * cellWidth, y * cellHeight,
                            cellWidth - line, cellHeight - line);
                    }
                    else
                    {
                        if (!m_historyStates[x + y * m_columns])
                        {
                            painter.FillRectangle(
                                deadBrush, x * cellWidth, y * cellHeight,
                                cellWidth - line, cellHeight - line);
                        }
                        else
                        {
                            painter.FillRectangle(
                                historyBrush, x * cellWidth, y * cellHeight,
                                cellWidth - line, cellHeight - line);
                        }
                    }
                }
            }
        }
    }
}