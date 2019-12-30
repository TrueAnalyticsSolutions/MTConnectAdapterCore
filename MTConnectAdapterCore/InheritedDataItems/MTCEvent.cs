using System;
using System.Collections.Generic;
using System.Text;

namespace MTConnect {
  /// <summary>
  /// Event is just an alias for DataItem
  /// </summary>
  public class Event:DataItem {
    public Event(string name) : base(name) {
      base.Category = Categories.Event;
    }
  }
}
