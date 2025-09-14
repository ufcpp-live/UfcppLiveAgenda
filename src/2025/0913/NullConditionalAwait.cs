var t = Task.CompletedTask;

// これだとコンパイルエラー。
// nullable struct で GetAwaiter ない。
await t?.ConfigureAwait(false);

// ?? default 付けると危険。
// コンパイル通ったうえでランタイムエラー。
await (Task.CompletedTask?.ConfigureAwait(false)
    ?? default);

IDisposable? d = null;
d?.Dispose(); // よく書く。

// nullable struct なパターンでエラーに
IAsyncDisposable? ad = null;
await ad?.DisposeAsync();

/// await default(ValueTask) は平気。IsCompleted 扱い。
await (ad?.DisposeAsync() ?? default);
