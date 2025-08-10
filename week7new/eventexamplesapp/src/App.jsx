import React, { useState } from 'react';
import CurrencyConvertor from './components/CurrencyConvertor';

function App() {
  const [count, setCount] = useState(0);

  const sayHello = () => {
    console.log("Hello! This is a static message.");
  };

  const increment = () => {
    setCount(count + 1);
    sayHello();
  };

  const decrement = () => {
    setCount(count - 1);
  };

  const sayWelcome = (message) => {
    alert(message);
  };

  const handleClick = (e) => {
    alert("I was clicked");
    console.log("Synthetic Event: ", e);
  };

  return (
    <div style={{ padding: '20px' }}>
      <h1>🧪 React Events Example</h1>
      
      <h2>Counter: {count}</h2>
      <button onClick={increment}>Increment</button>
      <button onClick={decrement}>Decrement</button>

      <br /><br />
      <button onClick={() => sayWelcome("Welcome!")}>Say Welcome</button>

      <br /><br />
      <button onClick={handleClick}>Click Me (Synthetic Event)</button>

      <br /><br />
      <CurrencyConvertor />
    </div>
  );
}

export default App;
