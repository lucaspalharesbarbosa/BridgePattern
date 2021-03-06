﻿using Domain.Interfaces;

namespace BridgePattern {
    class StandardFormatter : IFormatter {
        public string Format(string key, string value) {
            return string.Format("{0}: {1}", key, value);
        }
    }
}