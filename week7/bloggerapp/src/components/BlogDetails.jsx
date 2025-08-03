import React from 'react';

const blogs = [
  { id: 1, title: 'React Basics', date: '2023-01-01' },
  { id: 2, title: 'Understanding JSX', date: '2023-02-15' },
];

function BlogDetails() {
  return (
    <div>
      <h2>📝 Blog Details</h2>
      <ul>
        {blogs.map(blog => (
          <li key={blog.id}>
            {blog.title} ({blog.date})
          </li>
        ))}
      </ul>
    </div>
  );
}

export default BlogDetails;
