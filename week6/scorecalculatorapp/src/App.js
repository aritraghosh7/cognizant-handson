import React from 'react';
import './App.css';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div className="App">
      <CalculateScore name="Aritra Ghosh" school="KIIT" total={450} goal={5} />
    </div>
  );
}

export default App;
