import React from 'react';

function Post({ title, body }) {
  return (
    <div style={{ border: '1px solid #ccc', padding: '16px', marginBottom: '12px' }}>
      <h3>{title}</h3>
      <p>{body}</p>
    </div>
  );
}

export default Post;
