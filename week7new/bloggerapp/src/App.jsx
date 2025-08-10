import React, { useState } from 'react';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  const [section, setSection] = useState('book'); // default

  const renderComponent = () => {
    switch (section) {
      case 'book':
        return <BookDetails />;
      case 'blog':
        return <BlogDetails />;
      case 'course':
        return <CourseDetails />;
      default:
        return <p>Please select a section</p>;
    }
  };

  return (
    <div style={{ padding: '20px' }}>
      <h1>📚 Blogger App</h1>

      {/* Option 1: Ternary */}
      <div>
        <button onClick={() => setSection('book')}>Book</button>
        <button onClick={() => setSection('blog')}>Blog</button>
        <button onClick={() => setSection('course')}>Course</button>
      </div>

      <br />

      {/* Option 2: Function Switch */}
      {renderComponent()}

      {/* Option 3: Logical AND */}
      {section === 'book' && <p>You are viewing books.</p>}

      {/* Option 4: IIFE */}
      {
        (() => {
          if (section === 'blog') {
            return <p>You're now in the blog section</p>;
          }
        })()
      }
    </div>
  );
}

export default App;
