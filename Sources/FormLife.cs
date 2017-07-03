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
using System.Windows.Forms;

namespace LifeEngine
{
    enum ZoomType { In, Out }
    
    public partial class FormLife : Form
    {
        private double m_probability;
        private int m_gridSize;
        private int m_simulationSpeed;
        private int m_stepNumber;
        private List<string> m_gameRules;

        private LifeGame m_lifeGame;
        private Timer m_timer;

        private int m_zoomStartX;
        private int m_zoomStartY;
        private int m_zoomMax;
        private double m_zoomRate;
        private int m_zoomCount;

        private DateTime m_startTime;
        
        public FormLife()
        {
            InitializeComponent();
            
            m_probability = 0.15;
            m_stepNumber = 0;
            m_gameRules = new List<string>();

            AddSizesToComboBox();
            AddSpeedsToComboBox();
            AddRulesToComboBox();

            m_sizeCombobox.SelectedIndex = 3;
            m_speedCombobox.SelectedIndex = 3;

            m_zoomStartX = m_panelScroller.Width;
            m_zoomStartY = m_panelScroller.Height;
            m_zoomMax = 5;
            m_zoomRate = 1.5;
            m_zoomCount = 0;

            m_lifeGrid.LinesVisible = m_menuGrid.Checked;

            m_timer = new Timer();
            m_timer.Enabled = false;
            m_timer.Interval = (11 - m_simulationSpeed) * 10;
            
            m_timer.Tick += new EventHandler(TimerTick);

            m_rulesCombobox.TextChanged += new EventHandler(RulesComboboxTextChanged);

            m_lifeGrid.MouseDown += new MouseEventHandler(LifeGridMouseDown);

            m_buttonStart.Click += new EventHandler(ButtonStartClick);
            m_buttonStop.Click += new EventHandler(ButtonStopClick);
            m_buttonStep.Click += new EventHandler(ButtonStepClick);

            m_buttonReset.Click += new EventHandler(ButtonResetClick);
            m_buttonClear.Click += new EventHandler(ButtonClearClick);
            m_buttonRandomize.Click += new EventHandler(ButtonRandomizeClick);

            m_buttonZoomIn.Click += new EventHandler(ButtonZoomInClick);
            m_buttonZoomOut.Click += new EventHandler(ButtonZoomOutClick);

            m_buttonStop.Enabled = false;
        }
        
        private void ResizeGrid()
        {
            m_gridSize = int.Parse(m_sizeCombobox.Items[m_sizeCombobox.SelectedIndex].ToString());

            m_lifeGrid.Columns = m_gridSize;
            m_lifeGrid.Rows = m_gridSize;

            m_lifeGame = new LifeGame(m_gridSize);
        }

        private void AddSizesToComboBox()
        {
            m_sizeCombobox.Items.Add("25");
            m_sizeCombobox.Items.Add("50");
            m_sizeCombobox.Items.Add("75");
            m_sizeCombobox.Items.Add("100");
            m_sizeCombobox.Items.Add("150");
            m_sizeCombobox.Items.Add("200");
            m_sizeCombobox.Items.Add("250");
        }

        private void AddSpeedsToComboBox()
        {
            m_speedCombobox.Items.Add("1");
            m_speedCombobox.Items.Add("2");
            m_speedCombobox.Items.Add("5");
            m_speedCombobox.Items.Add("10");
        }

        private void AddRulesToComboBox()
        {
            // Rule Format: Survive number(s) "/" Birth number(s) " "
            // after the [space] anything else (e.g. description)
            // 9 is not a valid number!
            m_gameRules.Add("23/3          - Conway's Life");
            m_gameRules.Add("125/36        - 2x2");
            m_gameRules.Add("34/34         - 34 Life");
            m_gameRules.Add("1358/357      - Amoeba");
            m_gameRules.Add("35678/4678    - Anneal");
            m_gameRules.Add("4567/345      - Assimilation");
            m_gameRules.Add("235678/378    - Coagulations");
            m_gameRules.Add("45678/3       - Coral");
            m_gameRules.Add("34678/3678    - Day & Night");
            m_gameRules.Add("5678/35678    - Diamoeba");
            m_gameRules.Add("012345678/3   - Flakes");
            m_gameRules.Add("1/1           - Gnarl");
            m_gameRules.Add("23/36         - HighLife");
            m_gameRules.Add("34678/0123478 - Inverse Life");
            m_gameRules.Add("5/345         - Long Life");
            m_gameRules.Add("12345/3       - Maze");
            m_gameRules.Add("1234/3        - Mazectric");
            m_gameRules.Add("245/368       - Move");
            m_gameRules.Add("238/357       - Pseudo Life");
            m_gameRules.Add("1357/1357     - Replicator");
            m_gameRules.Add("/2            - Seeds");
            m_gameRules.Add("/234          - Serviettes");
            m_gameRules.Add("235678/3678   - Stains");
            m_gameRules.Add("2345/45678    - Walled cities");
            
            foreach (string rule in m_gameRules)
            {
                m_rulesCombobox.Items.Add(rule);
            }

            m_rulesCombobox.SelectedIndex = 0;
        }

        private void ZoomView(ZoomType zoomType)
        {
            if (zoomType == ZoomType.In)
            {
                if ((m_lifeGrid.Width < (m_zoomMax * m_zoomStartX)) &&
                    (m_lifeGrid.Height < (m_zoomMax * m_zoomStartY)))
                {
                    m_lifeGrid.Width = Convert.ToInt32(m_lifeGrid.Width * m_zoomRate);
                    m_lifeGrid.Height = Convert.ToInt32(m_lifeGrid.Height * m_zoomRate);
                    m_zoomCount += 1;
                }
            }
            else
            {
                if ((m_lifeGrid.Width > m_zoomStartX) ||
                    (m_lifeGrid.Height > m_zoomStartY))
                {
                    m_lifeGrid.Width = Convert.ToInt32(m_lifeGrid.Width / m_zoomRate);
                    m_lifeGrid.Height = Convert.ToInt32(m_lifeGrid.Height / m_zoomRate);
                    m_zoomCount -= 1;
                }
            }

            UpdateFormVisuals();
        }

        private void UpdateFormVisuals()
        {
            m_labelStepNumber.Text = "Generation: ";

            if (m_stepNumber > 0)
                m_labelStepNumber.Text += m_stepNumber.ToString();
            else
                m_labelStepNumber.Text += 0;

            m_labelPopulation.Text = "Population: ";

            if (m_lifeGame.LiveCellCount > 0)
                m_labelPopulation.Text += m_lifeGame.LiveCellCount;
            else
                m_labelPopulation.Text += 0;

            m_labelZoomCount.Text = (m_zoomCount + 1).ToString();

            m_lifeGrid.UpdateGrid(m_lifeGame.GameGrid, m_lifeGame.HistoryGrid);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            m_lifeGame.Step();
            m_stepNumber += 1;

            UpdateFormVisuals();
        }

        private void RulesComboboxTextChanged(object sender, EventArgs e)
        {
            string[] ruleName = m_rulesCombobox.Text.Split(' ');

            m_lifeGame.ChangeRules(ruleName[0]);
        }

        private void LifeGridMouseDown(object sender, MouseEventArgs e)
        {
            int y = (int)(((float)e.Y) * m_lifeGame.Rows / m_lifeGrid.Height);
            int x = (int)(((float)e.X) * m_lifeGame.Columns / m_lifeGrid.Width);

            m_lifeGame.ToggleCellState(x, y);
            m_lifeGrid.UpdateGrid(m_lifeGame.GameGrid, m_lifeGame.HistoryGrid);
        }

        private void ButtonStartClick(object sender, EventArgs e)
        {
            m_lifeGame.SetStart();
            m_timer.Start();
            m_startTime = DateTime.Now;

            m_buttonStart.Enabled = false;
            m_buttonStop.Enabled = true;
        }

        private void ButtonStopClick(object sender, EventArgs e)
        {
            m_timer.Stop();
            UpdateFormVisuals();

            m_buttonStart.Enabled = true;
            m_buttonStop.Enabled = false;
        }

        private void ButtonStepClick(object sender, EventArgs e)
        {
            m_timer.Stop();
            m_lifeGame.Step();
            m_stepNumber += 1;

            UpdateFormVisuals();
        }

        private void ButtonResetClick(object sender, EventArgs e)
        {
            m_timer.Stop();
            m_lifeGame.ResetGrid();
            m_stepNumber = 0;

            UpdateFormVisuals();
        }

        private void ButtonClearClick(object sender, EventArgs e)
        {
            m_timer.Stop();
            m_lifeGame.ClearGrid();
            m_stepNumber = 0;

            UpdateFormVisuals();

            m_buttonStart.Enabled = true;
            m_buttonStop.Enabled = false;
        }

        private void ButtonRandomizeClick(object sender, EventArgs e)
        {
            m_lifeGame.Randomize(m_probability);
            m_stepNumber = 0;

            UpdateFormVisuals();
        }

        private void SizeComboboxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_timer != null)
                m_timer.Stop();

            if (m_lifeGame != null)
                m_lifeGame.ClearGrid();

            m_stepNumber = 0;

            if (m_lifeGame != null)
                UpdateFormVisuals();

            ResizeGrid();

            m_buttonStart.Enabled = true;
            m_buttonStop.Enabled = false;
        }

        private void SpeedComboboxSelectedIndexChanged(object sender, EventArgs e)
        {
            m_simulationSpeed = int.Parse(m_speedCombobox.Items[m_speedCombobox.SelectedIndex].ToString());

            if (m_timer != null)
                m_timer.Interval = (11 - m_simulationSpeed) * 10;
        }

        private void ButtonZoomInClick(object sender, EventArgs e)
        {
            ZoomView(ZoomType.In);
        }

        private void ButtonZoomOutClick(object sender, EventArgs e)
        {
            ZoomView(ZoomType.Out);
        }

        private void MenuOptionsShowGridClick(object sender, EventArgs e)
        {
            m_menuGrid.Checked = !(m_menuGrid.Checked);

            m_lifeGrid.LinesVisible = m_menuGrid.Checked;
        }

        private void MenuOptionsLiveCellColorClick(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            colorPicker.Color = m_lifeGrid.CellColorAlive;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                m_lifeGrid.CellColorAlive = colorPicker.Color;
            }
        }

        private void MenuOptionsDeadCellColorClick(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            colorPicker.Color = m_lifeGrid.CellColorDead;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                m_lifeGrid.CellColorDead = colorPicker.Color;
            }
        }

        private void MenuOptionsHistoryCellColorClick(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            colorPicker.Color = m_lifeGrid.CellColorHistory;

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                m_lifeGrid.CellColorHistory = colorPicker.Color;
            }
        }

        private void MenuHelpAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Game of Life is a cellular automata simulator which defaults to the rules for Conway's Game of Life. It can also be set to use several other GoL rulesets.\n\nCopyright © 2017 RangeMachine", "About");
        }
    }
}