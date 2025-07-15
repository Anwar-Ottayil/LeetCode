/* Write your T-SQL query statement below */
SELECT *
FROM Cinema
WHERE id % 2 = 1              -- Odd IDs
  AND description != 'boring' -- Not boring
ORDER BY rating DESC;