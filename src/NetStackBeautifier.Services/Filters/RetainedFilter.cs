namespace NetStackBeautifier.Services.Filters;

internal class RetainedFilter<T> : IPreFilter<T>
    where T : IBeautifier
{
    public void Filter(IFrameLine frameLine, RawRequest rawRequest)
    {
        if (frameLine == null || rawRequest == null)
        {
            return;
        }
        frameLine.Tags.TryAdd("fullLine", rawRequest.Value.Trim());
        frameLine.Tags.Add("startingIndex", rawRequest.Index.ToString());
    }
}