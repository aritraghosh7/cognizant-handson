import React from 'react';
import './App.css';
import CohortDetails from './CohortDetails';

function App() {
  const cohort1 = {
    name: "React Bootcamp",
    description: "Learn React from scratch.",
    status: "ongoing"
  };

  const cohort2 = {
    name: "Node.js Advanced",
    description: "Deep dive into Node.js.",
    status: "completed"
  };

  return (
    <div className="App">
      <CohortDetails cohort={cohort1} />
      <CohortDetails cohort={cohort2} />
    </div>
  );
}

export default App;
