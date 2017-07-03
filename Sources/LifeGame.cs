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
using System.Collections.Generic;
using System.Text;

namespace LifeEngine
{
    public sealed class LifeGame
    {
        private bool[] m_currentStates;
        private bool[] m_historyStates;
        private bool[] m_newStates;
        private bool[] m_startStates;
        private int m_rows;
        private int m_columns;
        private int m_cells;
        private int m_liveCells;
        private List<int> m_surviveRules;
        private List<int> m_birthRules;
        private string m_unparsedRules;

        public int Columns
        {
            get
            {
                return m_columns;
            }
        }

        public int Rows
        {
            get
            {
                return m_rows;
            }
        }

        public int Cells
        {
            get
            {
                return m_cells;
            }
        }

        public int LiveCellCount
        {
            get
            {
                return m_liveCells;
            }
        }

        public string Rules
        {
            get
            {
                return m_unparsedRules;
            }
        }

        public bool[] GameGrid
        {
            get
            {
                return m_currentStates;
            }
        }

        public bool[] HistoryGrid
        {
            get
            {
                return m_historyStates;
            }
        }

        public LifeGame(int gridSize)
            : this(gridSize, gridSize, "23/3")
        {
        }
        
        public LifeGame(int columns, int rows)
            : this(columns, rows, "23/3")
        {
        }
        
        public LifeGame(int columns, int rows, string rules)
        {
            m_columns = columns;
            m_rows = rows;
            m_cells = columns * rows;

            ClearGrid();
            m_startStates = new bool[m_cells];

            ChangeRules(rules);
        }
        
        public void ChangeRules(string rules)
        {
            if (rules.Contains("9") || !rules.Contains("/"))
                rules = "23/3";

            m_unparsedRules = rules;

            string survive = rules.Split('/')[0];
            string birth = rules.Split('/')[1];

            m_surviveRules = new List<int>();
            m_birthRules = new List<int>();

            for (int i = 0; i < survive.Length; i++)
            {
                m_surviveRules.Add(Int32.Parse(survive.Substring(i, 1)));
            }

            for (int i = 0; i < birth.Length; i++)
            {
                m_birthRules.Add(Int32.Parse(birth.Substring(i, 1)));
            }
        }
        
        public void ClearGrid()
        {
            m_liveCells = 0;
            m_currentStates = new bool[m_cells];
            m_historyStates = new bool[m_cells];
            m_newStates = new bool[m_cells];
        }
        
        public void Randomize(double probability)
        {
            Random random = new Random();
            m_liveCells = 0;

            for (int i = 0; i < m_cells; i++)
            {
                m_currentStates[i] = random.NextDouble() <= probability;

                if (m_currentStates[i])
                    m_liveCells += 1;
            }
        }
        
        public void ResetGrid()
        {
            m_startStates.CopyTo(m_currentStates, 0);
        }
        
        public void SetStart()
        {
            m_currentStates.CopyTo(m_startStates, 0);
        }
        
        public void Step()
        {
            AdvancePopulation();
            m_newStates.CopyTo(m_currentStates, 0);
        }
        
        public bool GetCellState(int x, int y)
        {
            if (y < 0 || y >= m_rows || x < 0 || x >= m_columns)
                return false;
            
            return m_currentStates[x + y * m_columns];
        }
        
        public void ToggleCellState(int x, int y)
        {
            if (y < 0 || y >= m_rows || x < 0 || x >= m_columns)
                return;

            int index = x + y * m_columns;
            m_currentStates[index] = !(m_currentStates[index]);
            
            if (m_currentStates[index])
                m_liveCells += 1;
            else
                m_liveCells -= 1;
        }
        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int y = 0; y < m_rows; y++)
            {
                for (int x = 0; x < m_columns; x++)
                {
                    stringBuilder.Append(m_currentStates[x + y * m_columns] ? '*' : '.');
                }

                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
        
        private void AdvancePopulation()
        {
            if (m_liveCells == 0)
                return;

            m_liveCells = 0;

            int neighbors;
            int index;
            bool alive;

            for (int y = 0; y < m_rows; y++)
            {
                for (int x = 0; x < m_columns; x++)
                {
                    neighbors = getNeighbors(x, y);
                    index = x + y * m_columns;
                    alive = m_currentStates[index];
                    
                    if ((alive && m_surviveRules.Contains(neighbors)) ||
                        (!alive && m_birthRules.Contains(neighbors)))
                    {
                        m_historyStates[index] = true;
                        m_newStates[index] = true;
                        m_liveCells += 1;
                    }
                    else
                        m_newStates[index] = false;
                }
            }
        }
        
        private int getNeighbors(int x, int y)
        {
            int neighborCount = 0;

            if ((x > 0 && y > 0) && m_currentStates[x - 1 + (y - 1) * m_columns])
                neighborCount += 1;

            if ((y > 0) && m_currentStates[x + (y - 1) * m_columns])
                neighborCount += 1;

            if ((x + 1 < m_columns && y > 0) && m_currentStates[x + 1 + (y - 1) * m_columns])
                neighborCount += 1;

            if ((x + 1 < m_columns) && m_currentStates[x + 1 + y * m_columns])
                neighborCount += 1;

            if ((x + 1 < m_columns && y + 1 < m_rows) && m_currentStates[x + 1 + (y + 1) * m_columns])
                neighborCount += 1;

            if ((y + 1 < m_rows) && m_currentStates[x + (y + 1) * m_columns])
                neighborCount += 1;

            if ((x > 0 && y + 1 < m_rows) && m_currentStates[x - 1 + (y + 1) * m_columns])
                neighborCount += 1;

            if ((x > 0) && m_currentStates[x - 1 + y * m_columns])
                neighborCount += 1;

            return neighborCount;
        }
    }
}