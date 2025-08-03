import React from 'react';

const courses = [
  { id: 1, name: 'ReactJS Fundamentals', duration: '4 weeks' },
  { id: 2, name: 'Advanced JavaScript', duration: '3 weeks' },
];

function CourseDetails() {
  return (
    <div>
      <h2>📖 Course Details</h2>
      <ul>
        {courses.map(course => (
          <li key={course.id}>
            {course.name} — {course.duration}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default CourseDetails;
