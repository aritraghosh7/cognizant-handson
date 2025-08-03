import React, { useState } from 'react';

function CurrencyConvertor() {
  const [rupees, setRupees] = useState('');
  const [euro, setEuro] = useState('');

  const handleConvert = (e) => {
    e.preventDefault();
    const euroValue = parseFloat(rupees) / 90; // Example rate
    setEuro(euroValue.toFixed(2));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const rupeesValue = parseFloat(euro) * 90;
    setRupees(rupeesValue.toFixed(2));
  };

  return (
    <div style={{ marginTop: '30px' }}>
      <h2>💱 Currency Convertor</h2>

      <form onSubmit={handleConvert}>
        <input
          type="number"
          placeholder="Rupees"
          value={rupees}
          onChange={(e) => setRupees(e.target.value)}
        />
        <button type="submit">Convert to Euro</button>
      </form>

      <form onSubmit={handleSubmit} style={{ marginTop: '10px' }}>
        <input
          type="number"
          placeholder="Euro"
          value={euro}
          onChange={(e) => setEuro(e.target.value)}
        />
        <button type="submit">Convert to Rupees</button>
      </form>
    </div>
  );
}

export default CurrencyConvertor;
