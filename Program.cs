using Amazon.S3;

var regionEndpoint = Environment.GetEnvironmentVariable("AWS_REGION") ?? "us-east-1";
var config = new AmazonS3Config
{
    RegionEndpoint = Amazon.RegionEndpoint.GetBySystemName(regionEndpoint)
};
_ = new AmazonS3Client(config);

Console.WriteLine("DotNetAwsStorage initialized successfully.");
