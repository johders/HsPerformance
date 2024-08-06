﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace HsPerformance.User.Mobile.ViewModels
{
    public partial class ExerciseListItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private Guid _id;

        [ObservableProperty]
        private UserViewModel? _user;

        [ObservableProperty]
        private DateTime _date;

        [ObservableProperty]
        private BaseExerciseViewModel _exercise;

        [ObservableProperty]
        private int _sets;

        [ObservableProperty]
        private int _reps;

        [ObservableProperty]
        private int _duration;

        [ObservableProperty]
        private int _rest;

        [ObservableProperty]
        private ExerciseStatusEnum _exerciseStatus;

        public ExerciseListItemViewModel(Guid id, DateTime date, 
            BaseExerciseViewModel exercise, int sets, int reps, int duration, int rest, 
            ExerciseStatusEnum status = ExerciseStatusEnum.NotCompleted, UserViewModel? user = null)
        {
            Id = id;           
            Date = date;
            Exercise = exercise;
            Sets = sets;
            Reps = reps;
            Duration = duration;
            Rest = rest;
            ExerciseStatus = status;
            User = user;
        }
    }
}
