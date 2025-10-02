using Microsoft.ML.Data;

namespace CoreLearning.MachineLearning.Session_10;

public class ResultModel
{
    [ColumnName("Score")]
    public float Salary { get; set; }
}