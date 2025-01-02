﻿namespace SpongeEngine.LMStudioSharp.Providers.LocalAI
{
    public interface ILocalAiProvider : IDisposable
    {
        Task<string> CompleteAsync(string prompt, CompletionOptions? options = null, CancellationToken cancellationToken = default);
        IAsyncEnumerable<string> StreamCompletionAsync(string prompt, CompletionOptions? options = null, CancellationToken cancellationToken = default);
        Task<bool> IsAvailableAsync(CancellationToken cancellationToken = default);
    }

    public class CompletionOptions
    {
        public string? ModelName { get; set; }
        public int? MaxTokens { get; set; }
        public float? Temperature { get; set; }
        public float? TopP { get; set; }
        public string[]? StopSequences { get; set; }
    }
}