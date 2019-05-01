﻿using KanbanBoard.BLL;
using KanbanBoard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.UI.WinForm
{
    public partial class frmTaskControl : Form
    {
        TodoTask task;
        BoardController _boardController;
        TodoTaskController _todoTaskController;
        public frmTaskControl()
        {
            InitializeComponent();
            _boardController = new BoardController();
            _todoTaskController = new TodoTaskController();
        }
    }
}
