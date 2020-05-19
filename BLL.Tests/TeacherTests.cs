using NUnit.Framework;
using System.Collections.Generic;
using Moq;
using BLL.Objects;
using BLL.Interfaces;

namespace BLL.Tests
{
    public class TeacherTests
    {
        [Test]
        public void Get_AddTeachers_expect_Get2NotEqualToTeachers2()
        {
            //Arrange
            List<Lesson> lessons = new List<Lesson>()
            {
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Thursday,
                    LessonNumber = 1,
                    LessonName = "Programming",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.SecondWeek,
                    DayOfTheWeek = Day.Monday,
                    LessonNumber = 3,
                    LessonName = "Math",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Tuesday,
                    LessonNumber = 3,
                    LessonName = "Philosophy",
                    Group = null,
                    Teacher = null
                }
            };
            Teacher[] teachers =
             {
                new Teacher
                {
                    Name = "Roman",
                    Surname = "Kutsenko",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Zinaida",
                    Surname = "Kuchma",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Vasil",
                    Surname = "Bondarchuk",
                    Post = "Teacher",
                    Lessons = lessons
                }
            };
            Mock<ITeacherService> service = new Mock<ITeacherService>();
            service.Setup(mock => mock.Get(1)).Returns(teachers[0]);
            service.Setup(mock => mock.Get(2)).Returns(teachers[1]);
            service.Setup(mock => mock.Get(3)).Returns(teachers[2]);
            Teacher expected = teachers[2];
            int id = 2;

            //Act
            ITeacherService Service = service.Object;
            Teacher actual = Service.Get(id);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void GetAll_AddTeachers_Expect_GetAllEqualToTeachers()
        {
            //Arrange
            List<Lesson> lessons = new List<Lesson>()
            {
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Thursday,
                    LessonNumber = 1,
                    LessonName = "Programming",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.SecondWeek,
                    DayOfTheWeek = Day.Monday,
                    LessonNumber = 3,
                    LessonName = "Math",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Tuesday,
                    LessonNumber = 3,
                    LessonName = "Philosophy",
                    Group = null,
                    Teacher = null
                }
            };
            Teacher[] teachers =
             {
                new Teacher
                {
                    Name = "Roman",
                    Surname = "Kutsenko",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Zinaida",
                    Surname = "Kuchma",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Vasil",
                    Surname = "Bondarchuk",
                    Post = "Teacher",
                    Lessons = lessons
                }
            };
            List<Teacher> expected = new List<Teacher> { teachers[0], teachers[1], teachers[2] };
            Mock<ITeacherService> service = new Mock<ITeacherService>();
            service.Setup(mock => mock.GetAll()).Returns(expected);

            //Act
            ITeacherService Service = service.Object;
            List<Teacher> actual = Service.GetAll();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_AddTeachers_Verify_MethodCalled()
        {
            //Arrange
            List<Lesson> lessons = new List<Lesson>()
            {
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Thursday,
                    LessonNumber = 1,
                    LessonName = "Programming",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.SecondWeek,
                    DayOfTheWeek = Day.Monday,
                    LessonNumber = 3,
                    LessonName = "Math",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Tuesday,
                    LessonNumber = 3,
                    LessonName = "Philosophy",
                    Group = null,
                    Teacher = null
                }
            };
            Teacher[] teachers =
             {
                new Teacher
                {
                    Name = "Roman",
                    Surname = "Kutsenko",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Zinaida",
                    Surname = "Kuchma",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Vasil",
                    Surname = "Bondarchuk",
                    Post = "Teacher",
                    Lessons = lessons
                }
            };
            Mock<ITeacherService> service = new Mock<ITeacherService>();
            service.Setup(mock => mock.Add(teachers[0])).Verifiable();
            service.Setup(mock => mock.Add(teachers[1])).Verifiable();
            service.Setup(mock => mock.Add(teachers[2])).Verifiable();

            //Act
            ITeacherService Service = service.Object;
            Service.Add(teachers[0]);
            Service.Add(teachers[1]);
            Service.Add(teachers[2]);

            //Assert
            service.VerifyAll();
        }

        [Test]
        public void Remove_RemoveTeachers_Verify_MethodCalled()
        {
            //Arrange
            List<Lesson> lessons = new List<Lesson>()
            {
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Thursday,
                    LessonNumber = 1,
                    LessonName = "Programming",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.SecondWeek,
                    DayOfTheWeek = Day.Monday,
                    LessonNumber = 3,
                    LessonName = "Math",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Tuesday,
                    LessonNumber = 3,
                    LessonName = "Philosophy",
                    Group = null,
                    Teacher = null
                }
            };
            Teacher[] teachers =
             {
                new Teacher
                {
                    Name = "Roman",
                    Surname = "Kutsenko",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Zinaida",
                    Surname = "Kuchma",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Vasil",
                    Surname = "Bondarchuk",
                    Post = "Teacher",
                    Lessons = lessons
                }
            };
            Mock<ITeacherService> service = new Mock<ITeacherService>();
            service.Setup(mock => mock.Remove(teachers[0])).Verifiable();
            service.Setup(mock => mock.Remove(teachers[1])).Verifiable();

            //Act
            ITeacherService Service = service.Object;
            Service.Remove(teachers[0]);
            Service.Remove(teachers[1]);

            //Assert
            service.VerifyAll();
        }

        [Test]
        public void Update_ChangeTeachers1_Verify_MethodCalled()
        {
            //Arrange
            List<Lesson> lessons = new List<Lesson>()
            {
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Thursday,
                    LessonNumber = 1,
                    LessonName = "Programming",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.SecondWeek,
                    DayOfTheWeek = Day.Monday,
                    LessonNumber = 3,
                    LessonName = "Math",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Tuesday,
                    LessonNumber = 3,
                    LessonName = "Philosophy",
                    Group = null,
                    Teacher = null
                }
            };
            Teacher[] teachers =
             {
                new Teacher
                {
                    Name = "Roman",
                    Surname = "Kutsenko",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Zinaida",
                    Surname = "Kuchma",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Vasil",
                    Surname = "Bondarchuk",
                    Post = "Teacher",
                    Lessons = lessons
                }
            };
            Mock<ITeacherService> service = new Mock<ITeacherService>();
            service.Setup(mock => mock.Update(1, teachers[2])).Verifiable();

            //Act
            ITeacherService Service = service.Object;
            Service.Update(1, teachers[2]);

            //Assert
            service.VerifyAll();
        }

        [Test]
        public void GetLessons_AddTeachers_Expect_GetLessons1EqualToLessons()
        {
            //Arrange
            List<Lesson> lessons = new List<Lesson>()
            {
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Thursday,
                    LessonNumber = 1,
                    LessonName = "Programming",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.SecondWeek,
                    DayOfTheWeek = Day.Monday,
                    LessonNumber = 3,
                    LessonName = "Math",
                    Group = null,
                    Teacher = null
                },
                new Lesson
                {
                    WeekNumber = Week.FirstWeek,
                    DayOfTheWeek = Day.Tuesday,
                    LessonNumber = 3,
                    LessonName = "Philosophy",
                    Group = null,
                    Teacher = null
                }
            };
            Teacher[] teachers =
             {
                new Teacher
                {
                    Name = "Roman",
                    Surname = "Kutsenko",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Zinaida",
                    Surname = "Kuchma",
                    Post = "Teacher",
                    Lessons = lessons
                },
                new Teacher
                {
                    Name = "Vasil",
                    Surname = "Bondarchuk",
                    Post = "Teacher",
                    Lessons = lessons
                }
            };
            Mock<ITeacherService> service = new Mock<ITeacherService>();
            service.Setup(mock => mock.GetLessons(1)).Returns(lessons);
            IEnumerable<Lesson> expected = lessons;

            //Act
            ITeacherService Service = service.Object;
            IEnumerable<Lesson> actual = Service.GetLessons(1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
