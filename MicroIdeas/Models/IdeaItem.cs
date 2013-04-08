﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MicroIdeas.Models
{
    public class IdeaItem : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _shortContent;

        [DataMember(Name = "shortContext")]
        public string ShortContent
        {
            get { return _shortContent; }
            set
            {
                if (_shortContent == value) return;
                _shortContent = value;
                OnPropertyChanged("ShortContent");
            }
        }

        private string _fullContent;
        [DataMember(Name = "fullContext")]
        public string FullContent
        {
            get { return _fullContent; }
            set
            {
                if (_fullContent == value) return;
                _fullContent = value;
                OnPropertyChanged("FullContent");
            }
        }

        private int _voteCount;

        [DataMember(Name = "vote")]
        public int VoteCount
        {
            get { return _voteCount; }
            set
            {
                if (_voteCount == value) return;
                _voteCount = value;
                OnPropertyChanged("VoteCount");
            }
        }

        private string _publisher;

        [DataMember(Name = "publisher")]
        public string Publisher
        {
            get { return _publisher; }
            set
            {
                if (_publisher == value) return;
                _publisher = value;
                OnPropertyChanged("Publisher");
            }
        }

        private DateTime _date;

        [DataMember(Name = "createAt")]
        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (_date == value) return;
                _date = value;
                OnPropertyChanged("Date");
            }
        }


        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion INotifyPropertyChanged
    }
}
