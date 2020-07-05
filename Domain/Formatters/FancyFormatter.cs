﻿using Domain.Interfaces;

namespace Domain.Formatters {
    public class FancyFormatter : IFormatter {
        public string Format(string key, string value) {
            return string.Format("-=! {0} ----- !=- {1}", key, value);
        }
    }
}
