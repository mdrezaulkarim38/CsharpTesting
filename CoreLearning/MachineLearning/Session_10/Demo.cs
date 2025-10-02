using Microsoft.ML;

namespace CoreLearning.MachineLearning.Session_10;

public class Demo
{
    public static void Execute()
    {
        MLContext context = new MLContext();
        List<InputModel> data = new List<InputModel>
        {
            new InputModel { YearsOfExperience = 0.5f, Salary = 22000 },
            new InputModel { YearsOfExperience = 1.0f, Salary = 23500 },
            new InputModel { YearsOfExperience = 1.5f, Salary = 25000 },
            new InputModel { YearsOfExperience = 2.0f, Salary = 26500 },
            new InputModel { YearsOfExperience = 2.5f, Salary = 28000 },
            new InputModel { YearsOfExperience = 3.0f, Salary = 29500 },
            new InputModel { YearsOfExperience = 3.5f, Salary = 31000 },
            new InputModel { YearsOfExperience = 4.0f, Salary = 32500 },
            new InputModel { YearsOfExperience = 4.5f, Salary = 34000 },
            new InputModel { YearsOfExperience = 5.0f, Salary = 36000 },
            new InputModel { YearsOfExperience = 5.5f, Salary = 37500 },
            new InputModel { YearsOfExperience = 6.0f, Salary = 39000 },
            new InputModel { YearsOfExperience = 6.5f, Salary = 40500 },
            new InputModel { YearsOfExperience = 7.0f, Salary = 42000 },
            new InputModel { YearsOfExperience = 7.5f, Salary = 43500 },
            new InputModel { YearsOfExperience = 8.0f, Salary = 45000 },
            new InputModel { YearsOfExperience = 8.5f, Salary = 46500 },
            new InputModel { YearsOfExperience = 9.0f, Salary = 48000 },
            new InputModel { YearsOfExperience = 9.5f, Salary = 49500 },
            new InputModel { YearsOfExperience = 10.0f, Salary = 51000 },
            new InputModel { YearsOfExperience = 10.5f, Salary = 52500 },
            new InputModel { YearsOfExperience = 11.0f, Salary = 54000 },
            new InputModel { YearsOfExperience = 11.5f, Salary = 55500 },
            new InputModel { YearsOfExperience = 12.0f, Salary = 57000 },
            new InputModel { YearsOfExperience = 12.5f, Salary = 58500 },
            new InputModel { YearsOfExperience = 13.0f, Salary = 60000 },
            new InputModel { YearsOfExperience = 13.5f, Salary = 61500 },
            new InputModel { YearsOfExperience = 14.0f, Salary = 63000 },
            new InputModel { YearsOfExperience = 14.5f, Salary = 64500 },
            new InputModel { YearsOfExperience = 15.0f, Salary = 66000 },
            new InputModel { YearsOfExperience = 15.5f, Salary = 67500 },
            new InputModel { YearsOfExperience = 16.0f, Salary = 69000 },
            new InputModel { YearsOfExperience = 16.5f, Salary = 70500 },
            new InputModel { YearsOfExperience = 17.0f, Salary = 72000 },
            new InputModel { YearsOfExperience = 17.5f, Salary = 73500 },
            new InputModel { YearsOfExperience = 18.0f, Salary = 75000 },
            new InputModel { YearsOfExperience = 18.5f, Salary = 76500 },
            new InputModel { YearsOfExperience = 19.0f, Salary = 78000 },
            new InputModel { YearsOfExperience = 19.5f, Salary = 79500 },
            new InputModel { YearsOfExperience = 20.0f, Salary = 81000 },
            new InputModel { YearsOfExperience = 0.8f, Salary = 22800 },
            new InputModel { YearsOfExperience = 1.2f, Salary = 24000 },
            new InputModel { YearsOfExperience = 1.8f, Salary = 25500 },
            new InputModel { YearsOfExperience = 2.3f, Salary = 27200 },
            new InputModel { YearsOfExperience = 2.9f, Salary = 28800 },
            new InputModel { YearsOfExperience = 3.4f, Salary = 30400 },
            new InputModel { YearsOfExperience = 4.1f, Salary = 32600 },
            new InputModel { YearsOfExperience = 4.8f, Salary = 34800 },
            new InputModel { YearsOfExperience = 5.6f, Salary = 37200 },
            new InputModel { YearsOfExperience = 6.2f, Salary = 38600 },
            new InputModel { YearsOfExperience = 6.9f, Salary = 41000 },
            new InputModel { YearsOfExperience = 7.3f, Salary = 42200 },
            new InputModel { YearsOfExperience = 7.9f, Salary = 44400 },
            new InputModel { YearsOfExperience = 8.4f, Salary = 46200 },
            new InputModel { YearsOfExperience = 9.1f, Salary = 48200 },
            new InputModel { YearsOfExperience = 9.7f, Salary = 49800 },
            new InputModel { YearsOfExperience = 10.3f, Salary = 51600 },
            new InputModel { YearsOfExperience = 11.1f, Salary = 54200 },
            new InputModel { YearsOfExperience = 11.7f, Salary = 55800 },
            new InputModel { YearsOfExperience = 12.3f, Salary = 57400 },
            new InputModel { YearsOfExperience = 12.8f, Salary = 59000 },
            new InputModel { YearsOfExperience = 13.2f, Salary = 60400 },
            new InputModel { YearsOfExperience = 13.9f, Salary = 62800 },
            new InputModel { YearsOfExperience = 14.6f, Salary = 64800 },
            new InputModel { YearsOfExperience = 15.2f, Salary = 66400 },
            new InputModel { YearsOfExperience = 15.7f, Salary = 67800 },
            new InputModel { YearsOfExperience = 16.3f, Salary = 69400 },
            new InputModel { YearsOfExperience = 16.8f, Salary = 70800 },
            new InputModel { YearsOfExperience = 17.4f, Salary = 73000 },
            new InputModel { YearsOfExperience = 17.9f, Salary = 74600 },
            new InputModel { YearsOfExperience = 18.2f, Salary = 75400 },
            new InputModel { YearsOfExperience = 18.7f, Salary = 77000 },
            new InputModel { YearsOfExperience = 19.3f, Salary = 78600 },
            new InputModel { YearsOfExperience = 19.8f, Salary = 80200 },
            new InputModel { YearsOfExperience = 0.3f, Salary = 21500 },
            new InputModel { YearsOfExperience = 1.7f, Salary = 24800 },
            new InputModel { YearsOfExperience = 2.7f, Salary = 28500 },
            new InputModel { YearsOfExperience = 3.9f, Salary = 32000 },
            new InputModel { YearsOfExperience = 5.1f, Salary = 35800 },
            new InputModel { YearsOfExperience = 6.7f, Salary = 40200 },
            new InputModel { YearsOfExperience = 7.8f, Salary = 44200 },
            new InputModel { YearsOfExperience = 8.6f, Salary = 46800 },
            new InputModel { YearsOfExperience = 9.9f, Salary = 50800 },
            new InputModel { YearsOfExperience = 11.4f, Salary = 55200 },
            new InputModel { YearsOfExperience = 12.9f, Salary = 59200 },
            new InputModel { YearsOfExperience = 14.3f, Salary = 63400 },
            new InputModel { YearsOfExperience = 15.6f, Salary = 67600 },
            new InputModel { YearsOfExperience = 17.1f, Salary = 71600 },
            new InputModel { YearsOfExperience = 18.4f, Salary = 76000 },
            new InputModel { YearsOfExperience = 19.7f, Salary = 80000 },
            new InputModel { YearsOfExperience = 20.0f, Salary = 82000 }
        };

        IDataView trainingData = context.Data.LoadFromEnumerable(data);
        var estimator = context.Transforms.Concatenate("Features", new[] { "YearsOfExperience" });
        var pipeline = estimator.Append(context.Regression.Trainers.Sdca(labelColumnName: "Salary", maximumNumberOfIterations: 100));

        var model = pipeline.Fit(trainingData);
        var predictionEngine = context.Model.CreatePredictionEngine<InputModel, ResultModel>(model);
        var experience = new InputModel { YearsOfExperience = 7 };
        var result = predictionEngine.Predict(experience);
        Console.WriteLine($"Approx Salary for {experience.YearsOfExperience} Years of experience will be : {result.Salary}");
    }
}