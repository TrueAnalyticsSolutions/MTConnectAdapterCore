﻿using System.Text;

namespace MTConnect {
  /// <summary>
  /// A sample is a data item with a floating point value
  /// </summary>
  public class Sample : DataItem {
    public Sample(string name) : base(name) {
      base.Category = Categories.Sample;
    }
  }
}
