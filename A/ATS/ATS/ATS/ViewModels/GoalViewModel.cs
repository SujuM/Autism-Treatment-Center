﻿using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using ATS.Models;

namespace ATS.ViewModels
{
    public class GoalViewModel
    {
        public GoalModel Goal { get; set; }
        public ObservableCollection<TaskViewModel> Tasks { get; set; }
    }
}