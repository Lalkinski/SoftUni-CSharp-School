using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;

namespace RecourceCloud.Tests
{
    public class Tests
    {
        private DepartmentCloud cloud;

        [SetUp]
        public void Setup()
        {
            cloud = new DepartmentCloud();
        }

        [Test]
        public void LogTask_WithValidArgs_ReturnsSuccessMessage()
        {
            string[] args = { "1", "Exam", "OOP-Retake" };

            var result = cloud.LogTask(args);

            Assert.That(result, Is.EqualTo("Task logged successfully."));
            Assert.That(cloud.Tasks.Count, Is.EqualTo(1));
        }

        [Test]
        public void LogTask_WithDuplicateDetails_ReturnsAlreadyLoggedMessage()
        {
            cloud.LogTask(new string[] { "1", "Workshop", "Encapsulation" });

            var result = cloud.LogTask(new string[] { "2", "Presentation", "Encapsulation" });
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Encapsulation is already logged."));
                Assert.That(cloud.Tasks, Has.Count.EqualTo(1));
            });
        }

        [Test]
        public void CreateResource_WithoutTasks_ReturnsFalse()
        {
            var result = cloud.CreateResource();
            Assert.That(result, Is.False);
        }

        [Test]
        public void CreateResource_FromTask_SuccessfullyCreatesResource()
        {
            cloud.LogTask(new string[] { "1", "Exam", "C#Fundamentals" });
            var creationResult = cloud.CreateResource();

            Assert.Multiple(() =>
            {
                Assert.That(creationResult, Is.True);
                Assert.That(cloud.Resources, Has.Count.EqualTo(1));
                var resource = cloud.Resources.First();
                Assert.That(resource.Name, Is.EqualTo("C#Fundamentals"));
                Assert.That(resource.ResourceType, Is.EqualTo("Exam"));
            });
        }

        [Test]
        public void TestResource_WithExistingResource_SetsIsTestedTrue()
        {
            cloud.LogTask(new string[] { "1", "Exam", "JavaDB" });
            cloud.CreateResource();

            var resource = cloud.TestResource("JavaDB");

            Assert.Multiple(() =>
            {
                Assert.That(resource, Is.Not.Null);
                Assert.That(resource.IsTested, Is.True);
            });
        }

        [Test]
        public void TestResource_WithNonExistingResource_ReturnsNull()
        {
            var resource = cloud.TestResource("NonExisting");

            Assert.That(resource, Is.Null);
        }

        [Test]
        public void CreateResource_WithMultipleTasks_CreatesResourceFromHighestPriorityTask()
        {
            cloud.LogTask(new string[] { "2", "Workshop", "SnakeGame" });
            cloud.LogTask(new string[] { "1", "Exam", "CSharpAdvanced" });

            cloud.CreateResource();

            Assert.Multiple(() =>
            {
                Assert.That(cloud.Tasks, Has.Count.EqualTo(1));
                Assert.That(cloud.Resources, Has.Count.EqualTo(1));
                var resource = cloud.Resources.First();
                Assert.That(resource.Name, Is.EqualTo("CSharpAdvanced"));
                Assert.That(resource.ResourceType, Is.EqualTo("Exam"));
                Assert.That(cloud.Tasks.First().ResourceName, Is.EqualTo("SnakeGame"));
            });
        }

        [Test]
        public void LogTask_WithInvalidNumberOfArgs_ThrowsArgumentException()
        {
            string[] argsFewer = { "1", "Exam" };
            string[] argsMore = { "1", "Exam", "OOP-Retake", "ExtraArg" };

            var exFewer = Assert.Throws<ArgumentException>(() => cloud.LogTask(argsFewer));
            Assert.That(exFewer.Message, Is.EqualTo("All arguments are required."));

            var exMore = Assert.Throws<ArgumentException>(() => cloud.LogTask(argsMore));
            Assert.That(exMore.Message, Is.EqualTo("All arguments are required."));
        }

        [Test]
        public void LogTask_WithNullArgs_ThrowsArgumentException()
        {
            string[] argsWithNull = { "1", null, "OOP-Retake" };

            var exception = Assert.Throws<ArgumentException>(() => cloud.LogTask(argsWithNull));
            Assert.That(exception.Message, Contains.Substring("Arguments values cannot be null."));
        }
    }
}