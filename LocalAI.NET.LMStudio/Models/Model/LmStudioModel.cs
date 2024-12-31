﻿using Newtonsoft.Json;

namespace LocalAI.NET.LMStudio.Models.Model
{
    public class LmStudioModel
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;
    
        [JsonProperty("object")]
        public string Object { get; set; } = string.Empty;
    
        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;
    
        [JsonProperty("publisher")]
        public string Publisher { get; set; } = string.Empty;
    
        [JsonProperty("arch")]
        public string Architecture { get; set; } = string.Empty;
    
        [JsonProperty("compatibility_type")]
        public string CompatibilityType { get; set; } = string.Empty;
    
        [JsonProperty("quantization")]
        public string Quantization { get; set; } = string.Empty;
    
        [JsonProperty("state")]
        public string State { get; set; } = string.Empty;
    
        [JsonProperty("max_context_length")]
        public int MaxContextLength { get; set; }
    }
}