using System.ComponentModel.DataAnnotations;

namespace ColorTransfer
{
    public enum ColorTransferMode
    {
        [Display(Name = nameof(Texts.ColorTransferModeMean), Description = nameof(Texts.ColorTransferModeMeanDescription), ResourceType = typeof(Texts))]
        Mean = 1,

        [Display(Name = nameof(Texts.ColorTransferModeMeanAndVariance), Description = nameof(Texts.ColorTransferModeMeanAndVarianceDescription), ResourceType = typeof(Texts))]
        MeanAndVariance = 2,

        [Display(Name = nameof(Texts.ColorTransferModeHistogram), Description = nameof(Texts.ColorTransferModeHistogramDescription), ResourceType = typeof(Texts))]
        Histogram = 4,
    }
}
