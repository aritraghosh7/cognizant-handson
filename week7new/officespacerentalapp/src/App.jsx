import React from 'react';

function App() {
  const officeList = [
    {
      name: 'Sky Tower Workspace',
      rent: 45000,
      address: 'Downtown Business Street, Delhi',
      image: 'https://via.placeholder.com/200x100?text=Office+1',
    },
    {
      name: 'Green Valley Office',
      rent: 65000,
      address: 'MG Road, Bangalore',
      image: 'https://via.placeholder.com/200x100?text=Office+2',
    },
    {
      name: 'City Center Suites',
      rent: 58000,
      address: 'Sector 62, Noida',
      image: 'https://via.placeholder.com/200x100?text=Office+3',
    },
  ];

  const headingStyle = {
    textAlign: 'center',
    marginBottom: '20px',
    fontSize: '28px',
  };

  const rentStyle = (rent) => ({
    color: rent < 60000 ? 'red' : 'green',
    fontWeight: 'bold',
  });

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h1 style={headingStyle}>🏢 Office Space Rental App</h1>

      {officeList.map((office, index) => (
        <div
          key={index}
          style={{
            border: '1px solid #ccc',
            borderRadius: '10px',
            marginBottom: '15px',
            padding: '15px',
            maxWidth: '400px',
          }}
        >
          <img src={office.image} alt={office.name} style={{ width: '100%' }} />
          <h2>{office.name}</h2>
          <p>
            <strong>Rent:</strong>{' '}
            <span style={rentStyle(office.rent)}>₹{office.rent}</span>
          </p>
          <p>
            <strong>Address:</strong> {office.address}
          </p>
        </div>
      ))}
    </div>
  );
}

export default App;
