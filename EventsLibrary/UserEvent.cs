using System;
using System.Collections.Generic;
using System.Text;

namespace EventsLibrary {

    public class UserEvent {

        private int nbr = 0;

        public delegate void EventHandler(object sender, EventArgs e);

        public event EventHandler RaiseEvent;

        public void Add1() {
            nbr++;
            if(nbr % 5 == 0) {
                FireEvent();
            }
        }

        private void FireEvent() {
            var e = new EventArgs();
            OnFireEvent(e);
        }

        public virtual void OnFireEvent(EventArgs e) {
            if(RaiseEvent != null)
                RaiseEvent(this, e);
        }
    }
}
