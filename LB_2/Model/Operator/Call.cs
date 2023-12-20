using System;

namespace LB_1
{
    [Serializable]
    public readonly struct Call
    {
        private readonly string _to;
        private readonly DateTime _date;
        private readonly uint _duration;

        public Call(string to, DateTime date, uint duration)
        {
            _to = to;
            _date = date;
            _duration = duration;
        }

        public override string ToString() => 
            $"To number: {_to} | Date: {_date:MM/dd/yyyy hh:mm:ss.fff} | Duration: {_duration}";
    }
}